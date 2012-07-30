using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Almacen.Data.Entities;
using Spring.Context;
using Spring.Context.Support;
using Almacen.Business.ModEntrada;
using Almacen.Business;

namespace Almacen.View
{
    public partial class FrmEntrada : Form
    {
        #region Variables Miembro
        public IEntradaService EntradaService;
        public static List<BindingSource> lstEntradaDetalle;
        public static Entrada EntradaActual;
        //public static Entrada EntradaActualModificar;
        public Pedido PedidoActual;
        private decimal douDescuentoXpza;
        private decimal douIVA;
        private bool blnModificacion; 
        #endregion

        #region Constructores
        public FrmEntrada()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            EntradaService = ctx["entradaService"] as IEntradaService;
            EnlaceDatos();
            InicializarListas();
        }
   
        #endregion

        #region Eventos

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtFolio,e);
        }

        private void txtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtFolio.TextLength>0 && blnModificacion && int.Parse(txtFolio.Text) > 0 )
                    {
                        CargaEntrada();
                    }
                    break;
            }
        }

        private void txtFactura_KeyDown(object sender, KeyEventArgs e)
        {
            //Simple Tab = Enter
            Fx.OnKeyTab(txtFactura, e);
        }

        private void txtNoPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtNoPedido, e);
        }

        private void txtNoPedido_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtNoPedido.TextLength > 0)
                    {
                        CargaArticulos(0);
                    }
                    break;
            }
        }

        private void dgvArticulos0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvArticulos0.CurrentCell.ColumnIndex == 4)
            {
                var txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= dgvArticulos0_KeyPress;
                    txt.KeyPress += dgvArticulos0_KeyPress;
                }
            }
        }
        private void dgvArticulos0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvArticulos0.CurrentCell.ColumnIndex == 4)
            {
                Fx.OnDecimal(dgvArticulos0[
                    dgvArticulos0.CurrentCell.ColumnIndex,dgvArticulos0.CurrentCell.RowIndex].EditedFormattedValue, e);
            }
        }

        private void dgvArticulos0_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void dgvArticulos0_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex>=0)
            {
                var objPedido = dgvArticulos0.CurrentRow.DataBoundItem as PedidoDetalle;
                if (objPedido.Recibida > objPedido.XEntregar || objPedido.XEntregar == 0 || objPedido.Recibida == 0)
                {
                    MessageBox.Show(@"Cantidad Recibida Mayor a Cantidad por Recibir, Verifique . .",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var intRemove=0;
                    var bolFlag = false;
                    var bolModificacion = false;
                    var bolNuevo = true;
                    var bisTemp = new BindingSource();
                    foreach (var bisIn in lstEntradaDetalle)
                    {
                        foreach (EntradaDetalle objEntradaDetalle in bisIn)
                        {
                            if (objEntradaDetalle.Clave == objPedido.Articulo.Id.CveArt)
                            {
                                bolNuevo = false;
                            }
                        }
                        if (bolNuevo==false)
                        {
                            bisTemp = bisIn;
                            break;
                        }
                    }
                    var frmEntradaCaducidad = new FrmEntradaCaducidad
                    {
                        ArticuloActual = objPedido.Articulo,
                        douPrecioEntrada = ((decimal)objPedido.PrecioUnitario - douDescuentoXpza) * (1+(douIVA/100)),
                        douRecibida = objPedido.Recibida,
                        bisTemp = bisTemp
                    };
                    frmEntradaCaducidad.ShowDialog();
                    bolModificacion = frmEntradaCaducidad.bolModificacion;
                    
                    if (bolModificacion && bolNuevo==false)
                    {
                        foreach (var bisIn in lstEntradaDetalle)
                        {
                            intRemove++;
                            foreach (EntradaDetalle objEntradaDetalle in bisIn)
                            {
                                if (objEntradaDetalle.Clave == objPedido.Articulo.Id.CveArt)
                                {
                                    bolFlag = true;
                                    break;
                                }
                            }
                            if (bolFlag)
                            {
                                lstEntradaDetalle.RemoveAt(intRemove - 1);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bisEntrada.DataSource = new Entrada();
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = true;
            blnModificacion = false;
            Habilita();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bisEntradaDetalle.DataSource = new List<EntradaDetalle>();

            if (int.Parse(txtFolio.Text) == 0)
            {
                MessageBox.Show(@"El Numero de Entrada NO Puede ser '0', Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if(dtFecha.Value.Year > EntradaService.EntradaDao.FechaServidor().Year)
                {
                    MessageBox.Show(@"No Puede Registrar Entradas de Años Posteriores, Verifique . .",
                                     @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(EntradaService.CierreDao.CierreExiste(FrmAlmacen.AlmacenActual.IdAlmacen,dtFecha.Value.Month,dtFecha.Value.Year))
                    {
                        MessageBox.Show(@"Ya Existe Cierre de Mes, Ya No Puede Registrar la Entrada, Verifique . . ",
                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtFecha.Focus();
                    }
                    else
                    {
                        if(blnModificacion)
                        {
                            foreach (var bisIN in lstEntradaDetalle)
                            {
                                foreach (EntradaDetalle objEntradaDetalle in bisIN)
                                {
                                    bisEntradaDetalle.Add(objEntradaDetalle);
                                }
                            }
                            GuardaEntrada();
                        }
                        else
                        {
                            if (EntradaService.EntradaDao.EntradaExiste(dtFecha.Value.Year, FrmAlmacen.AlmacenActual.IdAlmacen, int.Parse(txtFolio.Text)))
                            {
                                MessageBox.Show(@"El Numero de Entrada Ya Existe, Verifique . .",
                                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                foreach (var bisIN in lstEntradaDetalle)
                                {
                                    foreach (EntradaDetalle objEntradaDetalle in bisIN)
                                    {
                                        bisEntradaDetalle.Add(objEntradaDetalle);
                                    }
                                }
                                GuardaEntrada();
                            }
                        }
                    }
                        
                }
                
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cmbAnioEntrada.Enabled = true;
            txtFolio.Enabled = true;
            blnModificacion = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            txtFolio.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Inhabilita();
        }
        #endregion

        #region Metodos
        
        private void MasterDetail()
        {
        //    var datD = new DataSet();
        //    var dtParent = new DataTable("Parent");
        //    var dtChild = new DataTable("Child");

        //    dtParent.Columns.Add("CveArt", typeof(int));
        //    dtParent.Columns.Add("Cantidad", typeof(string));
        //    dtChild.Columns.Add("CveArt", typeof(int));
        //    dtChild.Columns.Add("Cadena", typeof(string));
            
        //    var bisTmp = EntradaService.CargaPedidoDetalle(2, 2011, 2, "F");
        //    foreach (var pedidoDetalle in bisTmp)
        //    {
        //        dtParent.Rows.Add(pedidoDetalle.Articulo.Id.CveArt, pedidoDetalle.Cantidad);
        //    }

        //    datD.Tables.Add(dtParent);
        //    datD.Tables.Add(dtChild);
            
        //    datD.Relations.Add("ParentChild", dtParent.Columns["CveArt"], dtChild.Columns["CveArt"]);

        ////'Bind the parent source to the parent table.
        //    bindingSource1.DataSource = datD;
        //    bindingSource1.DataMember = "Parent";

        ////'Bind the child source to the relationship.
        //    bindingSource2.DataSource =bindingSource1;
        //    bindingSource2.DataMember = "ParentChild";


        //    gridParent.DataSource = bindingSource1;
        ////'Bind the child control to the child source.
        //    gridChild.DataSource = bindingSource2;
        }


        private void InicializarListas()
        {
            lstEntradaDetalle= new List<BindingSource>();
            var dtActual = EntradaService.EntradaDao.FechaServidor();

            cmbAnioEntrada.Maximum = dtActual.Year;
            cmbAnioEntrada.Value = dtActual.Year;
            cmbAnioEntrada.Minimum = dtActual.Year - 1;

            //dtFecha.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFecha.Value = dtActual;
            //dtFecha.MinDate = new DateTime(dtActual.Year, 1, 1);
            
            var listItem = new List<Item>
            {
                new Item("MAYOR", 1),
                new Item("MENOR", 2),
                new Item("DONACIÓN", 3),
                new Item("EXTRAMUROS", 4)
            };
            cmbTipoPedido.DisplayMember = "Name";
            cmbTipoPedido.ValueMember = "Value";
            cmbTipoPedido.DataSource = listItem;
            cmbTipoPedido.SelectedIndex = 0;

            ResizeGridArticulos();

            EntradaService.UsuariosAlmacen(cmbRecibio,FrmAlmacen.AlmacenActual.IdAlmacen);
            EntradaService.UsuariosAlmacen(cmbSuperviso, FrmAlmacen.AlmacenActual.IdAlmacen);

            
        }

        private void EnlaceDatos()
        {
            txtFolio.DataBindings.Add(new Binding("Text", bisEntrada, "NumeroEntrada", true));
            dtFecha.DataBindings.Add(new Binding("Value", bisEntrada, "FechaEntrada", true));
            txtFactura.DataBindings.Add(new Binding("Text", bisEntrada, "NumeroFactura", true));
            cmbRecibio.DataBindings.Add(new Binding("SelectedValue", bisEntrada, "Recibio", true));
            cmbSuperviso.DataBindings.Add(new Binding("SelectedValue", bisEntrada, "Supervisor", true));
            EntradaActual = new Entrada();
            bisEntrada.DataSource = EntradaActual;
        }

        private void CargaEntrada()
        {
            lstEntradaDetalle = new List<BindingSource>();
            EntradaActual = EntradaService.EntradaDao.CargaEntrada((int)cmbAnioEntrada.Value, FrmAlmacen.AlmacenActual.IdAlmacen, int.Parse(txtFolio.Text),
                                                                    FrmAcceso.UsuarioLog.IdUsuario);
            if (EntradaActual != null)
            {
                bisEntrada.DataSource = EntradaActual;
                txtFolio.Enabled = false;
                txtFactura.Enabled = true;
                txtNoPedido.Text = EntradaActual.Pedido.NumeroPedido.ToString();
                cmbTipoPedido.SelectedValue = EntradaActual.Pedido.CatTipopedido.IdTipoped;
                cmbAnioEntrada.Value = EntradaActual.Pedido.FechaPedido.Value.Year;
                var bisTmp = new BindingSource();
                var intCveArt=0;
                foreach (var entradaDetalle in EntradaActual.EntradaDetalle)
                {
                    var objTmp = new EntradaDetalle()
                    {
                        IdEntradaDetalle = entradaDetalle.IdEntradaDetalle,
                        Entrada = entradaDetalle.Entrada,
                        Articulo = entradaDetalle.Articulo,
                        NoLote = entradaDetalle.NoLote,
                        Cantidad = entradaDetalle.Cantidad,
                        Existencia = entradaDetalle.Existencia,
                        FechaCaducidad = entradaDetalle.FechaCaducidad,
                        PrecioEntrada = entradaDetalle.PrecioEntrada,
                        Clave = entradaDetalle.Articulo.Id.CveArt
                    };
                    if (intCveArt!=entradaDetalle.Articulo.Id.CveArt && intCveArt!=0)
                    {
                        lstEntradaDetalle.Add(bisTmp);
                        bisTmp= new BindingSource {objTmp};
                    }
                    else
                    {
                        bisTmp.Add(objTmp);
                    }
                    intCveArt = entradaDetalle.Articulo.Id.CveArt;                    
                }
                lstEntradaDetalle.Add(bisTmp);
                CargaArticulos(EntradaActual.IdEntrada);
                btnGuardar.Enabled = EntradaService.SalidaDetalleDao.SalidaExiste(EntradaActual.IdEntrada) ? false : true;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {
                MessageBox.Show(@"El Numero de Entrada No Existe o Fue Capturado Por Otro Usuario, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void CargaArticulos(long intIdEntrada)
        {
            PedidoActual= new Pedido();
            if(blnModificacion==false)lstEntradaDetalle= new List<BindingSource>();
            PedidoActual = EntradaService.CargaPedido(
                int.Parse(txtNoPedido.Text), (int)cmbAnioEntrada.Value,(int)cmbTipoPedido.SelectedValue, 
                FrmAlmacen.AlmacenActual.IdAlmacen, intIdEntrada, blnModificacion);
            if (PedidoActual == null)
            {
                MessageBox.Show(@"El Pedido No Existe, Verifique . .",
                                       @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = false;
            }
            else
            {
                bisPedidoDetalle.DataSource = PedidoActual.PedidoDetalle;
                douDescuentoXpza = (decimal)PedidoActual.ImporteDescuento /
                    PedidoActual.PedidoDetalle.Sum(pedidoDetalle => (decimal)pedidoDetalle.Cantidad);
                douIVA = PedidoActual.Iva.Id.Porcentaje;
                cmbTipoPedido.Enabled = false;
                cmbAnioEntrada.Enabled = false;
                txtNoPedido.Enabled = false;
               
                if(blnModificacion==false)
                {
                    //txtFolio.Text = EntradaService.EntradaDao.NumeroEntrada(EntradaService.EntradaDao.FechaServidor().Year,
                    //    FrmAlmacen.AlmacenActual.IdAlmacen).ToString();
                    CargaFolioNuevo();
                    btnGuardar.Enabled = true;
                }
            }
            
        }

        private void GuardaEntrada()
        {
            try
            {
                var listaError = new RichTextBox();
                var lblNumErrors = new Label();
                if (blnModificacion) 
                { EntradaUpdate(); }
                else
                { EntradaSave(); }
                if (Util.DatosValidos2<Entrada>(EntradaActual, lblNumErrors, listaError))
                {
                   
                        if (EntradaService.EntradaDetalleDao.MovimientosPosteriores(
                            FrmAlmacen.AlmacenActual.IdAlmacen, ArticulosPedido(), dtFecha.Value) || 
                            EntradaService.SalidaDetalleDao.MovimientosPosteriores(
                            FrmAlmacen.AlmacenActual.IdAlmacen, ArticulosPedido(), dtFecha.Value)
                            )
                        {
                            if (MessageBox.Show(@"Existen Movimientos Posteriores, ¿Se Actualizaran Costos ?", @"Almacenes", 
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                //si no existen mov guardar
                                //ReActualizaCostoPromedio();//validar q no existan entradas ni salidas posteriores
                                EntradaService.GuardaEntrada(ref EntradaActual, blnModificacion);
                                MessageBox.Show(@"Entrada Almacenada o Actualizada Exitosamente",
                                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                                Inhabilita();
                            }
                        }
                        else
                        {
                            //si no existen mov guardar
                            EntradaService.GuardaEntrada(ref EntradaActual, blnModificacion);
                            //ActualizaCosto();//validar q no existan entradas ni salidas posteriores
                            MessageBox.Show(@"Entrada Almacenada o Actualizada Exitosamente",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            Inhabilita();
                        }
                }
                else
                {
                    MessageBox.Show(lblNumErrors.Text + "\r" + listaError.Text,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EntradaSave()
        {
            try
            {
                
                EntradaActual = new Entrada();
                EntradaActual = bisEntrada.DataSource as Entrada;
                EntradaActual.EntradaDetalle = bisEntradaDetalle.DataSource as List<EntradaDetalle>;
                EntradaActual.Pedido = PedidoActual;
                if(txtFolio.Text.Length!=0)EntradaActual.NumeroEntrada = int.Parse(txtFolio.Text);
                EntradaActual.FechaEntrada = dtFecha.Value;
                EntradaActual.EstadoEntrada = "A";
                EntradaActual.Almacen = PedidoActual.Almacen;
                EntradaActual.CatActividad = PedidoActual.CatActividad;
                EntradaActual.CatPresupuesto = PedidoActual.CatPresupuesto;
                EntradaActual.Usuario = FrmAcceso.UsuarioLog;
                EntradaActual.IpTerminal = Util.ipTerminal();
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void EntradaUpdate()
        {
            try
            {
                EntradaActual = new Entrada();
                EntradaActual = bisEntrada.DataSource as Entrada;
                EntradaActual.EntradaDetalle = bisEntradaDetalle.DataSource as List<EntradaDetalle>;
                EntradaActual.Pedido = PedidoActual;
                EntradaActual.Almacen = PedidoActual.Almacen;
                EntradaActual.Usuario = FrmAcceso.UsuarioLog;
                EntradaActual.IpTerminal = Util.ipTerminal();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizaCosto()
        {
            foreach (var bisIn in lstEntradaDetalle)
            {
                decimal douTmp=0;
                int intCveArt=0;
                decimal douPrecioEntrada = 0;
        
                foreach (EntradaDetalle objEntradaDetalle in bisIn)
                {
                    douTmp= douTmp +  (decimal)objEntradaDetalle.Cantidad;
                    intCveArt = objEntradaDetalle.Clave;
                    douPrecioEntrada = (decimal)objEntradaDetalle.PrecioEntrada;
                }

                foreach (var pedidoDetalle in PedidoActual.PedidoDetalle)
                {
                    if(intCveArt==pedidoDetalle.Clave)
                    {
                        try
                        {
                            var costoPromedioId = new CostoPromedioId(pedidoDetalle.Articulo);
                            var costoPromedio = new CostoPromedio(costoPromedioId);
                            costoPromedio.CostoPromedioMember = ((pedidoDetalle.CantidadTotal * pedidoDetalle.CostoPromedio)
                                                                + (douTmp * douPrecioEntrada)) / (douTmp + pedidoDetalle.CantidadTotal);
                            EntradaService.CostoPromedioDao.Update(costoPromedio);
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion del Costo Promedio de " + pedidoDetalle.Descripcion + " " + ee.Message,
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private Collection<int> ArticulosPedido()
        {
            var result = new Collection<int>();
            foreach (var pedidoDetalle in PedidoActual.PedidoDetalle)
            {
                result.Add(pedidoDetalle.Articulo.Id.CveArt);
            }
            return result;
        }

        private void ResizeGridArticulos()
        {
            bisPedidoDetalle.DataSource = new List<PedidoDetalle>();
            dgvArticulos0.AutoGenerateColumns = false;
            //dgvArticulos0.AllowUserToAddRows = false;
            //dgvArticulos0.AutoSize = true;
            dgvArticulos0.DataSource = bisPedidoDetalle;

            DataGridViewColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Clave",
                Name = "Clave",
                ReadOnly = true,
                Width = 35,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False
            };
            dgvArticulos0.Columns.Add(column);


            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                Name = "Descripción",
                ReadOnly = true,
                Width = 600,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False
            };
            dgvArticulos0.Columns.Add(column);


            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                Name = "Solicitado",
                ReadOnly = true,
                Width = 60,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = {Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n"}
            };
            dgvArticulos0.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "XEntregar",
                Name = "Por Entregar",
                ReadOnly = true,
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n" }
            };
            dgvArticulos0.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Recibida",
                Name = "Cantidad Recibida",
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n" },
                
            };
            dgvArticulos0.Columns.Add(column);

            column = new DataGridViewButtonColumn()
            {
                DataPropertyName = "",
                Name = "Caducidad",
                Width = 60,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                Text = "Ingresar",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Standard
        
            };
            dgvArticulos0.Columns.Add(column);
            
            dgvArticulos0.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Limpiar()
        {
            PedidoActual = new Pedido();
            EntradaActual = new Entrada();
            lstEntradaDetalle = new List<BindingSource>();
            bisEntrada.DataSource = new Entrada();
            bisEntradaDetalle.DataSource = new List<EntradaDetalle>();
            bisPedidoDetalle.DataSource = new List<PedidoDetalle>();
            txtNoPedido.Text = string.Empty;

            var dtActual = EntradaService.EntradaDao.FechaServidor();
            cmbAnioEntrada.Value = dtActual.Year;
            dtFecha.Value = dtActual;
            txtFolio.Text = string.Empty;
        }
        private void Habilita()
        {
            txtFolio.Enabled = true;
            dtFecha.Enabled = true;
            txtFactura.Enabled = true;
            cmbTipoPedido.Enabled = true;
            cmbAnioEntrada.Enabled = true;
            txtNoPedido.Enabled = true;
        }

        private void Inhabilita()
        {
            txtFolio.Enabled = false;
            dtFecha.Enabled = false;
            txtFactura.Enabled = false;
            cmbTipoPedido.Enabled = false;
            cmbAnioEntrada.Enabled = false;
            txtNoPedido.Enabled = false;

            btnGuardar.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
            
        }
        
        private void ReActualizaCostoPromedio()
        {
            int intCveArt = 0;
            var dtCierre = EntradaService.CierreDao.CargaUltimaFecha(FrmAlmacen.AlmacenActual.IdAlmacen);
            var dtUltimaEntrada = EntradaService.EntradaDao.CargaUltimaFecha(FrmAlmacen.AlmacenActual);
            var dtUltimaSalida = EntradaService.SalidaDao.CargaUltimaFecha(FrmAlmacen.AlmacenActual);
            foreach (var bisIn in lstEntradaDetalle)
            {
                foreach (EntradaDetalle objEntradaDetalle in bisIn)
                {
                    intCveArt = objEntradaDetalle.Clave;
                }

                foreach (var pedidoDetalle in PedidoActual.PedidoDetalle)
                {
                    if (intCveArt == pedidoDetalle.Clave)
                    {
                        try
                        {
                            //fechas dtcierre 
                            //Busca Cierre Anterior
                            var objCierre = EntradaService.CierreDao.CargaCierrexArticulo(pedidoDetalle.Articulo.Id.CveArt, 
                                FrmAlmacen.AlmacenActual.IdAlmacen, dtCierre.Month, dtCierre.Year);
                            //Busca Entradas Salidas y Calcula
                            decimal[] tm = CierrePaso(pedidoDetalle.Articulo, dtCierre.AddDays(1), 
                                dtUltimaEntrada >= dtUltimaSalida ? dtUltimaEntrada : dtUltimaSalida,
                                objCierre == null ? 0 : (decimal)objCierre.Existencia, objCierre == null ? 0 : objCierre.Importe, FrmAlmacen.AlmacenActual);

                            var costoPromedioId = new CostoPromedioId(pedidoDetalle.Articulo);
                            var costoPromedio = new CostoPromedio(costoPromedioId);
                            costoPromedio.CostoPromedioMember = tm[1];
                            EntradaService.CostoPromedioDao.Update(costoPromedio);
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion del Costo Promedio de " + pedidoDetalle.Descripcion + " " + ee.Message,
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private decimal[] CierrePaso(Articulo articulo, DateTime dtFechaIni, DateTime dtFechaFin, decimal decExistencia,
                                        decimal decCosto, Data.Entities.Almacen almacen)
        {
            //Delete from ult_cpf=cierrepaso where almacen=xalma
            var lstCierrePaso = EntradaService.CierrePasoDao.CargaCierrePaso(almacen.IdAlmacen);
            EntradaService.BorraCierrePaso(ref lstCierrePaso);

            //Busca Entradas
            var lstEntradas = EntradaService.CierrePasoDao.CargaEntradas(articulo.Id.CveArt, dtFechaIni, dtFechaFin,
                                                                             almacen.IdAlmacen);
            foreach (var objEntrada in lstEntradas)
            {
                var CierrePasoId = new CierrePasoId(Convert.ToDateTime(objEntrada[3]), articulo, (long)objEntrada[0], "E");
                var CierrePaso = new CierrePaso(CierrePasoId)
                {
                    Cantidad = (decimal)objEntrada[1],
                    CostoP = (decimal)objEntrada[2]
                };
                EntradaService.CierrePasoDao.Update(CierrePaso);
            }
            
            //Busca Salidas
            var lstSalidas = EntradaService.CierrePasoDao.CargaSalidas(articulo.Id.CveArt, dtFechaIni, dtFechaFin,
                                                                        almacen.IdAlmacen);
            foreach (var objSalida in lstSalidas)
            {
                var CierrePasoId = new CierrePasoId(Convert.ToDateTime(objSalida[3]), articulo, (long)objSalida[0], "S");
                var CierrePaso = new CierrePaso(CierrePasoId)
                {
                    Cantidad = (decimal)objSalida[1],
                    CostoP = (decimal)objSalida[2]
                };
                EntradaService.CierrePasoDao.Update(CierrePaso);
            }

            //Calcula
            lstCierrePaso = EntradaService.CierrePasoDao.CargaCierrePaso(almacen.IdAlmacen);
            foreach (var cierrePaso in lstCierrePaso)
            {
                if(cierrePaso.Id.EntSal=="S")
                {
                    decExistencia = (decimal) (decExistencia - cierrePaso.Cantidad);
                    //update salida_detalle
                    var objSalidaDetalles = EntradaService.SalidaDetalleDao.CargaSalidaDetalles(
                        (int)cierrePaso.Id.Llave, articulo.Id.CveArt);
                    foreach (var salidaDetalle in objSalidaDetalles)
                    {
                        salidaDetalle.CostoPromedio = decCosto;
                        EntradaService.SalidaDetalleDao.Update(salidaDetalle);
                    }
                }
                else
                {
                    if(decExistencia<=0)
                    {
                        decCosto = (decimal)cierrePaso.CostoP;
                        decExistencia = (decimal) (decExistencia + cierrePaso.Cantidad);
                    }
                    else
                    {
                        decCosto = (decimal)(((decExistencia * decCosto) + (cierrePaso.Cantidad * cierrePaso.CostoP))
                                                    /(decExistencia + cierrePaso.Cantidad));
                        decExistencia = (decimal) (decExistencia + cierrePaso.Cantidad);
                    }
                }
            }

            if(decExistencia>0 || decCosto>0)
            {
                var objArticuloId = new ArticuloId(articulo.Id.CveArt, almacen);
                var objArticulo = EntradaService.ArticuloDao.Get(objArticuloId);
                objArticulo.MovimientoProm = decCosto;
                EntradaService.ArticuloDao.Update(objArticulo);
            }

            //Delete from ult_cpf=cierrepaso where almacen=xalma
            lstCierrePaso = EntradaService.CierrePasoDao.CargaCierrePaso(almacen.IdAlmacen);
            EntradaService.BorraCierrePaso(ref lstCierrePaso);

            return new[] { decExistencia, decCosto };
            
        }
     
        private void CargaFolioNuevo()
        {
            txtFolio.Text = EntradaService.EntradaDao.NumeroEntrada(dtFecha.Value.Year,
                        FrmAlmacen.AlmacenActual.IdAlmacen).ToString();
            txtFolio.Focus();
        }
        #endregion

        private void cmbAnioEntrada_ValueChanged(object sender, EventArgs e)
        {
            if(cmbAnioEntrada.Value<dtFecha.Value.Year)
            {
                dtFecha.MinDate = new DateTime((int)cmbAnioEntrada.Value, 1, 1);
                dtFecha.MaxDate = new DateTime((int)cmbAnioEntrada.Value, 12, 31);
            }
            else
            {
                dtFecha.MaxDate = new DateTime((int)cmbAnioEntrada.Value, 12, 31);
                dtFecha.MinDate = new DateTime((int)cmbAnioEntrada.Value, 1, 1);
                var dtActual = EntradaService.EntradaDao.FechaServidor();
                dtFecha.Value = dtActual;
            }
           CargaFolioNuevo();
        }

        private void dtFecha_Validated(object sender, EventArgs e)
        {
            CargaFolioNuevo();
        }

        
    }
}

