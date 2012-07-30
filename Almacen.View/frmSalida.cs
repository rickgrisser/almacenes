using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Almacen.Data.Entities;
using Spring.Context;
using Spring.Context.Support;
using Almacen.Business.ModSalida;
using Almacen.Business;

namespace Almacen.View
{
    public partial class FrmSalida : Form
    {
        #region Variables Miembro
        public ISalidaService SalidaService;
        private static Salida SalidaActual;
        private static Salida SalidaActualModificacion;
        private bool blnModificacion;
        
        #endregion

        #region Constructores
        public FrmSalida()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            SalidaService = ctx["salidaService"] as ISalidaService;
            EnlaceDatos();
            InicializarListas();
        }
        #endregion

        #region Eventos

        private void txtNumeroSalida_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtNumeroSalida.TextLength > 0 && blnModificacion && int.Parse(txtNumeroSalida.Text) > 0)
                    {
                        CargaSalida(int.Parse(txtNumeroSalida.Text));
                    }
                    break;
            }
            
        }

        private void txtNumeroSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtNumeroSalida, e);
        }

        private void txtNoOrden_KeyDown(object sender, KeyEventArgs e)
        {
            //Simple Tab = Enter
            Fx.OnKeyTab(txtNoOrden, e);
        }

        private void txtNoOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtNoOrden, e);
        }

        private void txtCveArea_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtCveArea.TextLength > 0 && int.Parse(txtCveArea.Text) > 0)
                    {
                        SalidaService.CargaArea(cmbArea, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
                                                           int.Parse(txtCveArea.Text));
                        if(cmbArea.Items.Count ==0 )
                        {
                            MessageBox.Show(@"Clave de Area No Existe , Verifique . .",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private void txtCveArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtCveArea, e);
        }

        private void txtVoBo_KeyDown(object sender, KeyEventArgs e)
        {
            //Simple Tab = Enter
            Fx.OnKeyTab(txtVoBo, e);
        }
        
        private void txtRecibio_KeyDown(object sender, KeyEventArgs e)
        {
            //Simple Tab = Enter
            Fx.OnKeyTab(txtRecibio, e);
        }

        private void cmbArea_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (cmbArea.Text.Length > 0)
                    {
                        SalidaService.CargaAreas(cmbArea, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
                                                           '%' + cmbArea.Text.ToUpper() + '%');
                        if (cmbArea.Items.Count == 0)
                        {
                            MessageBox.Show(@"El Area No Existe , Verifique . .",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

       private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilita();
            FechaActual();
            bisSalida.DataSource= new Salida();
            btnGuardar.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            CargaFolioNuevo();
            blnModificacion = false;
            //txtNumeroSalida.Focus();
        }

       private void btnGuardar_Click(object sender, EventArgs e)
       {
           if (int.Parse(txtNumeroSalida.Text) == 0)
           {
               MessageBox.Show(@"El Numero de Salida NO Puede ser '0', Verifique . .",
                                           @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
               if (dtFechaSalida.Value.Year > SalidaService.SalidaDao.FechaServidor().Year)
               {
                   MessageBox.Show(@"No Puede Registrar Entradas de Años Posteriores, Verifique . .",
                                   @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               else
               {
                   if (SalidaService.CierreDao.CierreExiste(FrmAlmacen.AlmacenActual.IdAlmacen, dtFechaSalida.Value.Month,
                                                             dtFechaSalida.Value.Year))
                   {
                       MessageBox.Show(@"Ya Existe Cierre de Mes, Ya No Puede Registrar la Salida, Verifique . . ",
                                       @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       dtFechaSalida.Focus();
                   }
                   else
                   {
                       if (blnModificacion)
                       {
                           GuardaSalida();
                       }
                       else
                       {
                           if (SalidaService.SalidaDao.SalidaExiste(dtFechaSalida.Value.Year,
                                FrmAlmacen.AlmacenActual.IdAlmacen,int.Parse(txtNumeroSalida.Text)))
                           {
                               MessageBox.Show(@"El Numero de Salida Ya Existe, Verifique . .",
                                               @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           }
                           else
                           {
                               GuardaSalida();
                           }
                       }
                   }
               }
           }
       }

       private void btnModificar_Click(object sender, EventArgs e)
       {
           txtNumeroSalida.Enabled = true;
           blnModificacion = true;
           btnAgregar.Enabled = false;
           btnModificar.Enabled = false;
           btnCancelar.Enabled = true;
           FechaActual();
           dtFechaSalida.Enabled = true;
       }

       private void btnCancelar_Click(object sender, EventArgs e)
       {
           Limpiar();
           Inhabilita();
       }

       private void dgvSalidasDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
       {
           if (dgvSalidasDetalle.CurrentCell.ColumnIndex == 4 || dgvSalidasDetalle.CurrentCell.ColumnIndex == 5
               || dgvSalidasDetalle.CurrentCell.ColumnIndex == 0)
           {
               var txt = e.Control as TextBox;
               if (txt != null)
               {
                   txt.KeyPress -= dgvSalidasDetalle_KeyPress;
                   txt.KeyPress += dgvSalidasDetalle_KeyPress;
               }
           }
       }

       private void dgvSalidasDetalle_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (dgvSalidasDetalle.CurrentCell.ColumnIndex == 4 || dgvSalidasDetalle.CurrentCell.ColumnIndex == 5)
           {
               Fx.OnDecimal(dgvSalidasDetalle[
                   dgvSalidasDetalle.CurrentCell.ColumnIndex, dgvSalidasDetalle.CurrentCell.RowIndex].EditedFormattedValue, e);
           }
           if (dgvSalidasDetalle.CurrentCell.ColumnIndex == 0)
           {
               Fx.OnNumeric(dgvSalidasDetalle[
                   dgvSalidasDetalle.CurrentCell.ColumnIndex, dgvSalidasDetalle.CurrentCell.RowIndex].EditedFormattedValue, e);
           }
       }

       private void dgvSalidasDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {

       }

       private void dgvSalidasDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
       {
           //Para realizar las validaciones
           try
           {
               //Posicionado en renglon}
               if (e.ColumnIndex == 0)
               {
                   if (TieneRepetidoRenglon(Convert.ToInt32(dgvSalidasDetalle[e.ColumnIndex, e.RowIndex].Value)))
                   {
                       bisSalidaDetalle.RemoveAt(e.RowIndex);
                       MessageBox.Show(@"Articulo Repetido, Verifique . .",
                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else
                   {

                       var objArticuloId = new ArticuloId(Convert.ToInt32(dgvSalidasDetalle[e.ColumnIndex, e.RowIndex].Value),
                                                           FrmAlmacen.AlmacenActual);
                       var objArticulo = SalidaService.ArticuloDao.Get(objArticuloId);
                       if (objArticulo != null)
                       {
                           var objSalidaDetalle = new SalidaDetalle
                           {
                               Articulo = objArticulo,
                               Clave = objArticulo.Id.CveArt,
                               Unidad = objArticulo.CatUnidad,
                               Existencia = SalidaService.EntradaDetalleDao.ExistenciaTotal(objArticulo.Id.CveArt,
                               FrmAlmacen.AlmacenActual.IdAlmacen)
                           };
                           bisSalidaDetalle.RemoveAt(e.RowIndex);
                           bisSalidaDetalle.Insert(e.RowIndex, objSalidaDetalle);
                       }
                       else
                       {
                           bisSalidaDetalle.RemoveAt(e.RowIndex);
                           MessageBox.Show(@"La Clave del Articulo No Existe, Verifique . .",
                                   @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                       return;
                   }
               }

               if (e.ColumnIndex == 5)
               {
                   if (Convert.ToDecimal(dgvSalidasDetalle[e.ColumnIndex, e.RowIndex].Value) > Convert.ToDecimal(dgvSalidasDetalle[3, e.RowIndex].Value))
                   {
                       MessageBox.Show(@"Existencia Insuficiente, Verifique . .",
                                       @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       dgvSalidasDetalle[e.ColumnIndex, e.RowIndex].Value = "";
                   }
               }

           }
           catch (Exception ee)
           {
               MessageBox.Show(@"Ocurrio un error en la insercion del Articulo " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

        #endregion

        #region Metodos

        private void CargaSalida(int intNumeroSalida)
        {
            SalidaActual = SalidaService.SalidaDao.CargaSalida(dtFechaSalida.Value.Year,
                            FrmAlmacen.AlmacenActual.IdAlmacen, intNumeroSalida, FrmAcceso.UsuarioLog.IdUsuario);
            if (SalidaActual != null)
            {
                bisSalida.DataSource = SalidaActual;

                var tmp = SalidaService.SalidaDetalleDao.CargaSumSurtida(SalidaActual.IdSalida);
               
                //Agregamos Renglon )
                foreach (var salidaDetalle in tmp)
                {
                    var objArticuloId = new ArticuloId((int)salidaDetalle[0], FrmAlmacen.AlmacenActual);
                    var objArticulo = SalidaService.ArticuloDao.Get(objArticuloId);
                    if (objArticulo != null)
                    {
                        var objSalidaDetalle = new SalidaDetalle
                        {
                            Articulo = objArticulo,
                            Clave = objArticulo.Id.CveArt,
                            Unidad = objArticulo.CatUnidad,
                            Existencia = SalidaService.EntradaDetalleDao.ExistenciaTotal(objArticulo.Id.CveArt,
                            FrmAlmacen.AlmacenActual.IdAlmacen),
                            CantidadPedida = (decimal)salidaDetalle[1],
                            CantidadSurtida = (decimal)salidaDetalle[2]
                        };
                        bisSalidaDetalle.Add(objSalidaDetalle);
                    }
                }
                
                
                SalidaService.CargaArea(cmbArea, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
                    SalidaActual.CatArea.CveArea);

                if (SalidaService.CierreDao.CierreExiste(FrmAlmacen.AlmacenActual.IdAlmacen, dtFechaSalida.Value.Month,
                                                             dtFechaSalida.Value.Year))
                {
                    MessageBox.Show(@"Ya Existe Cierre de Mes, No Puede Modificar la Salida . . ",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    if (FrmAlmacen.AlmacenActual.IdAlmacen.Contains("P"))
                    {
                        lblNoOrden.Visible = true;
                        txtNoOrden.Visible = true;
                        txtNoOrden.Enabled = true;
                    }
                    else
                    {
                        lblNoOrden.Visible = false;
                        txtNoOrden.Visible = false;
                        txtNoOrden.Enabled = false;
                    }
                    txtCveArea.Enabled = true;
                    cmbArea.Enabled = true;
                    cmbEntrego.Enabled = true;
                    txtVoBo.Enabled = true;
                    txtRecibio.Enabled = true;
                    btnGuardar.Enabled = true;
                    dgvSalidasDetalle.Enabled = true;
                }
                txtNumeroSalida.Enabled = false;
                dtFechaSalida.Enabled = false;
            }
            else
            {
                MessageBox.Show(@"El Numero de Salida No Existe o Fue Capturado Por Otro Usuario, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardaSalida()
        {
            try
            {
                var listaError = new RichTextBox();
                var lblNumErrors = new Label();
                if (blnModificacion)
                { SalidaUpdate(); }
                else
                { SalidaSave(); }
                if (Util.DatosValidos2<Salida>(SalidaActual, lblNumErrors, listaError))
                {
                    //samsung
                    if (blnModificacion)
                    {
                        SalidaActualModificacion = SalidaService.SalidaDao.CargaSalida(dtFechaSalida.Value.Year,
                            FrmAlmacen.AlmacenActual.IdAlmacen, int.Parse(txtNumeroSalida.Text), FrmAcceso.UsuarioLog.IdUsuario);
                        SalidaService.BorraSalida(ref SalidaActualModificacion);
                    }
                        
                        SalidaService.GuardaSalida(ref SalidaActual, blnModificacion);
                        MessageBox.Show(@"Salida Almacenada o Actualizada Exitosamente",
                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        Inhabilita();
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

        private void SalidaSave()
        {
            try
            {
                SalidaActual = new Salida();
                SalidaActual = bisSalida.DataSource as Salida;
                SalidaActual.SalidaDetalle = bisSalidaDetalle.DataSource as List<SalidaDetalle>;
                SalidaActual.EstadoSalida = "A";
                SalidaActual.CatArea = cmbArea.SelectedValue as CatArea;
                SalidaActual.FechaSalida = dtFechaSalida.Value;
                SalidaActual.Almacen = FrmAlmacen.AlmacenActual;
                SalidaActual.Usuario = FrmAcceso.UsuarioLog;
                SalidaActual.IpTerminal = Util.ipTerminal();
                SalidaActual.FechaAlta = SalidaService.SalidaDao.FechaServidor();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SalidaUpdate()
        {
            try
            {
                SalidaActual = new Salida();
                SalidaActual = bisSalida.DataSource as Salida;
                SalidaActual.SalidaDetalle = bisSalidaDetalle.DataSource as List<SalidaDetalle>;
                SalidaActual.CatArea = cmbArea.SelectedValue as CatArea;
                SalidaActual.Usuario = FrmAcceso.UsuarioLog;
                SalidaActual.IpTerminal = Util.ipTerminal();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       private void EnlaceDatos()
       {
           txtNumeroSalida.DataBindings.Add(new Binding("Text", bisSalida, "NumeroSalida", true));
           dtFechaSalida.DataBindings.Add(new Binding("Value", bisSalida, "FechaSalida", true));
           txtNoOrden.DataBindings.Add(new Binding("Text", bisSalida, "NoOrden", true));
           //cmbArea.DataBindings.Add(new Binding("SelectedValue", bisSalida, "CatArea", true));
           cmbEntrego.DataBindings.Add(new Binding("SelectedValue", bisSalida, "Entrego", true));
           txtVoBo.DataBindings.Add(new Binding("Text", bisSalida, "JefeServicio", true));
           txtRecibio.DataBindings.Add(new Binding("Text", bisSalida, "Recibio", true));
           SalidaActual = new Salida();
           bisSalida.DataSource = SalidaActual;
       }

        private void InicializarListas()
        {
            FechaActual();
            SalidaService.UsuariosAlmacen(cmbEntrego, FrmAlmacen.AlmacenActual.IdAlmacen);

            Limpiar();
            Inhabilita();
            ResizeGridArticulos();
        }
        
        private void FechaActual()
        {
            var dtActual = SalidaService.SalidaDao.FechaServidor();
            dtFechaSalida.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFechaSalida.Value = dtActual;
            dtFechaSalida.MinDate = new DateTime(dtActual.Year-1, 1, 1); 
        }

        private void ResizeGridArticulos()
        {
            bisSalidaDetalle.DataSource = new List<SalidaDetalle>();
            dgvSalidasDetalle.AutoGenerateColumns = false;
            dgvSalidasDetalle.AllowUserToAddRows = true;
            dgvSalidasDetalle.AllowUserToResizeColumns = false;
            //dgvArticulos0.AutoSize = true;
            dgvSalidasDetalle.DataSource = bisSalidaDetalle;

            DataGridViewColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Clave",
                Name = "Clave",
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            dgvSalidasDetalle.Columns.Add(column);


            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                Name = "Descripción",
                ReadOnly = true,
                Width = 550,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False
            };
            dgvSalidasDetalle.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Unidad",
                Name = "Unidad",
                ReadOnly = true,
                Width = 135,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }

            };
            dgvSalidasDetalle.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Existencia",
                Name = "Existencia",
                ReadOnly = true,
                Width = 60,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n" }
            };
            dgvSalidasDetalle.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CantidadPedida",
                Name = "Cantidad Pedida",
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n" }
            };
            dgvSalidasDetalle.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CantidadSurtida",
                Name = "Cantidad Surtida",
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n" },

            };
            dgvSalidasDetalle.Columns.Add(column);
            
            dgvSalidasDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Limpiar()
        {
            SalidaActual = new Salida();
            bisSalida.DataSource = new Salida();
            bisSalidaDetalle.DataSource = new List<SalidaDetalle>();
            cmbArea.DataSource = new List<CatArea>();

        }
        private void Habilita()
        {
            txtNumeroSalida.Enabled = true;
            dtFechaSalida.Enabled = true;
            //Verificar por el almacen de ortesis
            if(FrmAlmacen.AlmacenActual.IdAlmacen.Contains("P"))
            {
                lblNoOrden.Visible = true;
                txtNoOrden.Visible = true;
                txtNoOrden.Enabled = true;
            }
            else
            {
                lblNoOrden.Visible = false;
                txtNoOrden.Visible = false;
                txtNoOrden.Enabled = false;
            }

            txtCveArea.Enabled = true;
            cmbArea.Enabled = true;
            cmbEntrego.Enabled = true;

            txtVoBo.Enabled = true;
            txtRecibio.Enabled = true;
            dgvSalidasDetalle.Enabled = true;

        }

        private void Inhabilita()
        {
            txtNumeroSalida.Enabled = false;
            dtFechaSalida.Enabled = false;
            if (FrmAlmacen.AlmacenActual.IdAlmacen.Contains("P"))
            {
                lblNoOrden.Visible = true;
                txtNoOrden.Visible = true;
                txtNoOrden.Enabled = false;
            }
            else
            {
                lblNoOrden.Visible = false;
                txtNoOrden.Visible = false;
                txtNoOrden.Enabled = false;
            }

            txtCveArea.Enabled = false;
            cmbArea.Enabled = false;
            cmbEntrego.Enabled = false;

            txtVoBo.Enabled = false;
            txtRecibio.Enabled = false;

            dgvSalidasDetalle.Enabled = false;
            btnGuardar.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private bool TieneRepetidoRenglon(int intCveArt)
        {
            var intTmp = 0;
            for (var i = 0; i < dgvSalidasDetalle.Rows.Count - 1; i++)
            {
                if(Convert.ToInt32(dgvSalidasDetalle[0,i].Value) == intCveArt)
                {
                    intTmp++;
                }
            }
            return intTmp > 1;
        }

        private void CargaFolioNuevo()
        {
            txtNumeroSalida.Text = SalidaService.SalidaDao.NumeroSalida(dtFechaSalida.Value.Year,
                FrmAlmacen.AlmacenActual.IdAlmacen).ToString();
            txtNumeroSalida.Focus();
        }
        #endregion
        
        private void dtFechaSalida_Validated(object sender, EventArgs e)
        {
            CargaFolioNuevo();
        }
        
        //ISession sesion = SessionFactory.Instance;
        //Salida salidaActual = new Salida();
        //string a_salida = "";
        //string tipo_movimiento = "";
        //Usuario usua_entrego = new Usuario();
        //CatArea area_salida = new CatArea();

        //public frm_Salida()
        //{
        //    InitializeComponent();
        //}

        //private void btn_cancelar_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void frm_Salida_Load(object sender, EventArgs e)
        //{
        //    asigna_anio();
        //}

        //public void asigna_anio()
        //{
        //    IQuery query = sesion.GetNamedQuery("Salida.AnioActual");
        //    a_salida = query.UniqueResult<Int32>().ToString();

        //    query = sesion.GetNamedQuery("Salida.NumeroMaxSalida");
        //    query.SetParameter("idalmacen", frm_Acceso.almacenSelec.IdAlmacen);
        //    query.SetParameter("a_Salida", a_salida);
        //    int? max_salida = query.UniqueResult<Int32>();
        //    if (max_salida == null)
        //        max_salida = 0;
        //    max_salida = max_salida + 1;

        //    tb_numerosalida.Text = max_salida.ToString();

        //    deshabilita_campos();
        //    tb_numerosalida.Focus();
        //}

        //private void deshabilita_campos()
        //{
        //    if (frm_Acceso.almacenSelec.IdAlmacen.Contains("P"))
        //    {
        //        tb_noorden.Enabled = false;
        //    }
        //    else
        //    {
        //        tb_noorden.Visible = false;
        //        label4.Visible = false;
        //    }
        //    dt_fechasalida.Enabled = false;
        //    cb_entrego.Enabled = false;
        //    tb_vobo.Enabled = false;
        //    dataGridView1.Enabled = false;
        //    tb_cvearea.Enabled = false;
        //    cb_desarea.Enabled = false;
        //    tb_recibio.Enabled = false;
        //    btn_guardar.Enabled = false;
        //    btn_agregar.Enabled = true;
        //    btn_cancelar.Enabled = true;
        //    btn_editar.Enabled = true;
        //}

        //private void activa_campos(string tipo)
        //{
        //    if (frm_Acceso.almacenSelec.IdAlmacen.Contains("P"))
        //    {
        //        tb_noorden.Enabled = true;
        //    }
        //    dt_fechasalida.Enabled = true;
        //    cb_entrego.Enabled = true;
        //    tb_vobo.Enabled = true;
        //    dataGridView1.Enabled = true;
        //    tb_cvearea.Enabled = true;
        //    cb_desarea.Enabled = true;
        //    tb_recibio.Enabled = true;
        //    btn_guardar.Enabled = true;
        //    btn_agregar.Enabled = false;
        //    btn_editar.Enabled = false;

        //}

        //private void btn_agregar_Click(object sender, EventArgs e)
        //{
        //    tipo_movimiento = "Alta";
        //    IQuery query = sesion.GetNamedQuery("Salida.VerificaSal");
        //    query.SetParameter("idalmacen", frm_Acceso.almacenSelec.IdAlmacen);
        //    query.SetParameter("num_sal", tb_numerosalida.Text);
        //    query.SetParameter("a_Salida", a_salida);
        //    IList<Salida> salida_mod = query.List<Salida>();

        //    if (salida_mod.Count == 0)
        //    {
        //        activa_campos("A");
        //        carga_combos("A");
        //    }
        //    else
        //    {
        //        MessageBox.Show("La salida ya existe, elija modificacion");
        //    }
        //}


        //public void carga_combos(string tipo)
        //{
        //    bool tipo_area = false;
        //    string t_area = "";
        //    string nombre_aux = "";
        //    Usuario users = new Usuario();
        //    int cuantos = 0;
        //    int id_entrega = 0;
        //    string nombre_entrego = "";

        //    if (tipo == "M")
        //    {
        //        id_entrega = int.Parse(salidaActual.Recibio.ToString());
        //    }
        //    IQuery query = sesion.GetNamedQuery("Usuario.CargaCombo");
        //    query.SetParameter("id_almacen", frm_Acceso.almacenSelec.IdAlmacen);
        //    IList<Usuario> idcuantos = query.List<Usuario>();

        //    foreach (Usuario listausers in idcuantos)
        //    {
        //        if (cuantos == 0)
        //        {
        //            users = listausers;
        //            nombre_aux = listausers.Nombre.ToString();
        //            cb_entrego.Items.Add(listausers.Nombre.ToString());
        //            if (tipo == "M")
        //            {
        //                if (id_entrega == listausers.IdUsuario)
        //                {
        //                    nombre_entrego = listausers.Nombre;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (nombre_aux != listausers.Nombre)
        //            {
        //                nombre_aux = listausers.Nombre.ToString();
        //                cb_entrego.Items.Add(listausers.Nombre.ToString());
        //                if (tipo == "M")
        //                {
        //                    if (id_entrega == listausers.IdUsuario)
        //                    {
        //                        nombre_entrego = listausers.Nombre;
        //                    }
        //                }
        //            }

        //        }
        //        cuantos = cuantos++;
        //    }

        //    if (tipo == "M")
        //    {
        //       cb_entrego.Text = nombre_entrego;
        //    }

        //    tipo_area = frm_Acceso.almacenSelec.IdAlmacen.Contains("C");
        //    if (tipo_area)
        //    {
        //        t_area = "C";
        //    }
        //    else
        //    {
        //        t_area = "N";
        //    }
        //    AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        //    query = sesion.GetNamedQuery("CatArea.CargaAreas");
        //    query.SetParameter("tipo", t_area);
        //    IList<CatArea> areas = query.List<CatArea>();
        //    foreach (CatArea listaareas in areas)
        //    {
        //        cb_desarea.Items.Add(listaareas.DesArea.ToString());
        //        namesCollection.Add(listaareas.DesArea.ToString());    
        //    }
        //    cb_desarea.AutoCompleteCustomSource = namesCollection;
        //    cb_desarea.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    cb_desarea.AutoCompleteSource = AutoCompleteSource.CustomSource;
    
        //}

        //private void cb_entrego_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    IQuery query = sesion.GetNamedQuery("Usuario.TraeUsuario");
        //    query.SetParameter("nombre_usua", cb_entrego.Text);
        //    IList<Usuario> usua_rec = query.List<Usuario>();
        //    foreach (Usuario usuario_rec in usua_rec)
        //        usua_entrego = usuario_rec;
        //}

        //private void tb_vobo_Leave(object sender, EventArgs e)
        //{
        //    tb_vobo.Text = tb_vobo.Text.ToUpper();
        //    tb_recibio.Text = tb_vobo.Text;
        //}

        //private void tb_recibio_Leave(object sender, EventArgs e)
        //{
        //    tb_recibio.Text = tb_recibio.Text.ToUpper();
        //}

        //private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    string repite_clave = "N";
        //    try
        //    {
        //        if (e.ColumnIndex == 0)//Clave Articulo
        //        {
        //            try
        //            {
        //                for (int cuenta = 0; cuenta <= this.dataGridView1.Rows.Count; cuenta++)
        //                {
        //                    if (this.dataGridView1.Rows[cuenta].Cells[0].Value.ToString() == this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
        //                    {
        //                        if (cuenta != e.RowIndex)
        //                        {
        //                            repite_clave = "S";
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception )
        //            {
                        
        //            }
        //            if (repite_clave == "N")
        //            {
        //                int cveArt = Int32.Parse(this.dataGridView1.CurrentCell.Value.ToString());
        //                //Trae el almacen dinámicamente
        //                Almacen almacen = frm_Acceso.almacenSelec;
        //                ArticuloId articuloid = new ArticuloId(cveArt, almacen);
        //                Articulo articuloSelect = sesion.Get<Articulo>(articuloid);

        //                //Ponemos la descripcion
        //                this.dataGridView1.Rows[e.RowIndex].Cells[1].Value = articuloSelect.DesArticulo;
        //                //Ponemos la presentacion
        //                this.dataGridView1.Rows[e.RowIndex].Cells[2].Value = articuloSelect.CatUnidad.Unidad;

        //                IQuery query = sesion.GetNamedQuery("EntradaDetalle.TotExis");
        //                query.SetParameter("idalmacen", almacen.IdAlmacen);
        //                query.SetParameter("cveart", this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

        //                decimal? exis = query.UniqueResult<decimal>();

        //                this.dataGridView1.Rows[e.RowIndex].Cells[3].Value = exis;

        //            }
        //            else
        //            {
        //                this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
        //                MessageBox.Show("No Puede Repetir La Clave Del Artículo ",
        //                        "Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }

        //        }
        //        if (e.ColumnIndex > 3)
        //        {
        //            if (this.dataGridView1.Rows[e.RowIndex].Cells[1].Value == null)
        //            {
        //                this.dataGridView1.Rows[e.RowIndex].Cells[4].Value = "";
        //                this.dataGridView1.Rows[e.RowIndex].Cells[5].Value = "";
        //                MessageBox.Show("No puede omitir la clave del articulo ",
        //                                "Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        if (e.ColumnIndex == 5)
        //        {
        //            if (decimal.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()) > decimal.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()))
        //            {
        //                MessageBox.Show("Existencia Insuficiente, verifique ",
        //                                "Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }


        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("Valor no reconocido " + ee.Message,
        //             "Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
        //    }
        //}

        //private void cb_desarea_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        IQuery query = sesion.GetNamedQuery("CatArea.TraeArea");
        //        query.SetParameter("des_area", cb_desarea.Text);
        //        IList<CatArea> area_rec = query.List<CatArea>();
        //        if (area_rec.Count > 0)
        //        {
        //            foreach (CatArea area_sel in area_rec)
        //                area_salida = area_sel;
        //                tb_cvearea.Text = area_salida.CveArea.ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Area No Registrada ",
        //             "Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            cb_desarea.Focus();
        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("Area No Registrada " + ee.Message,
        //             "Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void tb_cvearea_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        IQuery query = sesion.GetNamedQuery("CatArea.TraeAreaCve");
        //        query.SetParameter("cve_area", tb_cvearea.Text);
        //        IList<CatArea> area_rec = query.List<CatArea>();
        //        if (area_rec.Count > 0)
        //        {
        //            foreach (CatArea area_sel in area_rec)
        //                area_salida = area_sel;
        //            cb_desarea.Text = area_salida.DesArea;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Area No Registrada ",
        //             "Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            tb_cvearea.Focus();
        //        }

        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("Area No Registrada " + ee.Message,
        //             "Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btn_guardar_Click(object sender, EventArgs e)
        //{
        //    guarda_salida();
        //}

        //private void guarda_salida()
        //{
        //    try
        //    {
        //        ITransaction tranx = sesion.Transaction;
        //        tranx.Begin();
        //        if (tipo_movimiento == "Modificacion")
        //        {
        //            sesion.Delete(salidaActual);
        //        }
        //        salidaActual = new Salida();

        //        IQuery query = sesion.GetNamedQuery("Entrada.FechaActual");
        //        DateTime fecha_salida = query.UniqueResult<DateTime>();

        //        salidaActual.NumeroSalida = int.Parse(tb_numerosalida.Text);
        //        salidaActual.FechaSalida = dt_fechasalida.Value;
        //        salidaActual.CatArea = area_salida;
        //        salidaActual.Entrego = usua_entrego.IdUsuario;
        //        salidaActual.Almacen = frm_Acceso.almacenSelec;
        //        salidaActual.EstadoSalida = "A";
        //        salidaActual.IpTerminal = frm_Acceso.ipTerminal;
        //        salidaActual.Usuario = frm_Acceso.usuarioLog;
        //        salidaActual.FechaAlta = fecha_salida;
        //        salidaActual.Modificacion = 0;
        //        salidaActual.JefeServicio = tb_vobo.Text;
        //        salidaActual.Recibio = tb_recibio.Text;
        //        salidaActual.NoOrden = "";
        //        salidaActual = (Salida)sesion.SaveOrUpdateCopy(salidaActual);
        //        //Guardamos los hijos
        //        //salidaActual.SalidaDetalle = llenaDetalle(salidaActual);

        //        tranx.Commit();
        //        sesion.Refresh(salidaActual);
        //        MessageBox.Show("Salida Registrada Correctamente ", "Almacenes", MessageBoxButtons.OK);
        //       // inicial();
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("Ocurrio un error en la insercion o actualizacion " + ee.Message,
        //            "Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btn_editar_Click(object sender, EventArgs e)
        //{
        //    tipo_movimiento = "Modificacion";
        //}


    }
}
