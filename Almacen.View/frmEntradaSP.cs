using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Almacen.Business.ModEntrada;
using Almacen.Data.Entities;
using Spring.Context;
using Spring.Context.Support;
using Almacen.Business.ModSalida;
using Almacen.Business;

namespace Almacen.View
{
    public partial class FrmEntradaSP : Form
    {
        #region Variables Miembro
        public IEntradaService EntradaService;
        private static Entrada EntradaActual;
        private bool blnModificacion;
        
        #endregion

        #region Constructores
        public FrmEntradaSP()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            EntradaService = ctx["entradaService"] as IEntradaService;
            EnlaceDatos();
            InicializarListas();
        }
        #endregion

        #region Eventos

        private void txtNumeroEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtNumeroEntrada.TextLength > 0 && blnModificacion && int.Parse(txtNumeroEntrada.Text) > 0)
                    {
                        CargaEntrada(int.Parse(txtNumeroEntrada.Text));
                    }
                    break;
            }
        }

        private void txtNumeroEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtNumeroEntrada, e);
        }

        private void txtFactura_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtFactura, e);
        }

       private void btnAgregar_Click(object sender, EventArgs e)
        {
            FechaActual();
            bisEntrada.DataSource = new Entrada();
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            blnModificacion = false;
            Habilita();
            CargaFolioNuevo();
            txtNumeroEntrada.Focus();
        }

       private void btnGuardar_Click(object sender, EventArgs e)
       {
           if (int.Parse(txtNumeroEntrada.Text) == 0)
           {
               MessageBox.Show(@"El Numero de Entrada NO Puede ser '0', Verifique . .",
                                           @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
               if (blnModificacion)
               {
                   
                   GuardaEntrada();
               }
               else
               {
                   if (EntradaService.EntradaDao.EntradaExiste(dtFechaEntrada.Value.Year, FrmAlmacen.AlmacenActual.IdAlmacen, int.Parse(txtNumeroEntrada.Text)))
                   {
                       MessageBox.Show(@"El Numero de Entrada Ya Existe, Verifique . .",
                                               @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else
                   {
                       GuardaEntrada();
                   }
               }
           }
       }

       private void btnModificar_Click(object sender, EventArgs e)
       {
           txtNumeroEntrada.Enabled = true;
           blnModificacion = true;
           btnAgregar.Enabled = false;
           btnModificar.Enabled = false;
           btnCancelar.Enabled = true;
           FechaActual();
           dtFechaEntrada.Enabled = true;
       }

       private void btnCancelar_Click(object sender, EventArgs e)
       {
           Limpiar();
           Inhabilita();
       }

       private void dgvEntradaDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
       {
           if (dgvEntradaDetalle.CurrentCell.ColumnIndex == 3 || dgvEntradaDetalle.CurrentCell.ColumnIndex == 4
               || dgvEntradaDetalle.CurrentCell.ColumnIndex == 0)
           {
               var txt = e.Control as TextBox;
               if (txt != null)
               {
                   txt.KeyPress -= dgvEntradaDetalle_KeyPress;
                   txt.KeyPress += dgvEntradaDetalle_KeyPress;
               }
           }
       }

       private void dgvEntradaDetalle_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (dgvEntradaDetalle.CurrentCell.ColumnIndex == 4)
           {
               Fx.OnDecimal(dgvEntradaDetalle[
                   dgvEntradaDetalle.CurrentCell.ColumnIndex, dgvEntradaDetalle.CurrentCell.RowIndex].EditedFormattedValue, e);
           }
           if (dgvEntradaDetalle.CurrentCell.ColumnIndex == 0 || dgvEntradaDetalle.CurrentCell.ColumnIndex == 3)
           {
               Fx.OnNumeric(dgvEntradaDetalle[
                   dgvEntradaDetalle.CurrentCell.ColumnIndex, dgvEntradaDetalle.CurrentCell.RowIndex].EditedFormattedValue, e);
           }
       }

       private void dgvEntradaDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {

       }

       private void dgvEntradaDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
       {
           //Para realizar las validaciones
           try
           {
               //Posicionado en renglon}
               if (e.ColumnIndex == 0)
               {
                   if (TieneRepetidoRenglon(Convert.ToInt32(dgvEntradaDetalle[e.ColumnIndex, e.RowIndex].Value)))
                   {
                       bisEntradaDetalle.RemoveAt(e.RowIndex);
                       MessageBox.Show(@"Articulo Repetido, Verifique . .",
                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else
                   {

                       var objArticuloId = new ArticuloId(Convert.ToInt32(dgvEntradaDetalle[e.ColumnIndex, e.RowIndex].Value),
                                                           FrmAlmacen.AlmacenActual);
                       var objArticulo = EntradaService.ArticuloDao.Get(objArticuloId);
                       if (objArticulo != null)
                       {
                           var objEntradaDetalle = new EntradaDetalle
                           {
                               Articulo = objArticulo
                           };
                           bisEntradaDetalle.RemoveAt(e.RowIndex);
                           bisEntradaDetalle.Insert(e.RowIndex, objEntradaDetalle);
                       }
                       else
                       {
                           bisEntradaDetalle.RemoveAt(e.RowIndex);
                           MessageBox.Show(@"La Clave del Articulo No Existe, Verifique . .",
                                   @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                       return;
                   }
               }

               if (e.ColumnIndex == 5)
               {
                   if (Convert.ToDecimal(dgvEntradaDetalle[e.ColumnIndex, e.RowIndex].Value) > Convert.ToDecimal(dgvEntradaDetalle[3, e.RowIndex].Value))
                   {
                       MessageBox.Show(@"Existencia Insuficiente, Verifique . .",
                                       @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       dgvEntradaDetalle[e.ColumnIndex, e.RowIndex].Value = "";
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

        private void CargaEntrada(int intNumeroEntrada)
        {
            EntradaActual = EntradaService.EntradaDao.CargaEntrada(dtFechaEntrada.Value.Year
                , FrmAlmacen.AlmacenActual.IdAlmacen, intNumeroEntrada,FrmAcceso.UsuarioLog.IdUsuario);
            if(EntradaActual!=null)
            {
                bisEntrada.DataSource = EntradaActual;
                bisEntradaDetalle.DataSource = EntradaActual.EntradaDetalle;
                Habilita();
                txtNumeroEntrada.Enabled = false;
                dtFechaEntrada.Enabled = false;
                btnGuardar.Enabled = true;
                dtFechaEntrada.Enabled = false;
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
                    
                        EntradaService.GuardaEntrada(ref EntradaActual, blnModificacion);
                        MessageBox.Show(@"Entrada Almacenada o Actualizada Exitosamente",
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
        
        private void EntradaSave()
        {
            try
            {

                EntradaActual = new Entrada();
                EntradaActual = bisEntrada.DataSource as Entrada;
                EntradaActual.EntradaDetalle = bisEntradaDetalle.DataSource as List<EntradaDetalle>;
                EntradaActual.FechaEntrada = dtFechaEntrada.Value;
                EntradaActual.EstadoEntrada = "A";
                EntradaActual.Almacen = FrmAlmacen.AlmacenActual;
                EntradaActual.Usuario = FrmAcceso.UsuarioLog;
                EntradaActual.IpTerminal = Util.ipTerminal();
                //EntradaActual.FechaAlta = EntradaService.EntradaDao.FechaServidor();

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
                EntradaActual.Usuario = FrmAcceso.UsuarioLog;
                EntradaActual.IpTerminal = Util.ipTerminal();
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnlaceDatos()
        {
            txtNumeroEntrada.DataBindings.Add(new Binding("Text", bisEntrada, "NumeroEntrada", true));
            dtFechaEntrada.DataBindings.Add(new Binding("Value", bisEntrada, "FechaEntrada", true));
            txtFactura.DataBindings.Add(new Binding("Text", bisEntrada, "NumeroFactura", true));
            cmbActividad.DataBindings.Add(new Binding("SelectedValue", bisEntrada, "CatActividad", true));
            cmbPresupuesto.DataBindings.Add(new Binding("SelectedValue", bisEntrada, "CatPresupuesto", true));
            cmbRecibio.DataBindings.Add(new Binding("SelectedValue", bisEntrada, "Recibio", true));
            cmbSuperviso.DataBindings.Add(new Binding("SelectedValue", bisEntrada, "Supervisor", true));
            EntradaActual = new Entrada();
            bisEntrada.DataSource = EntradaActual;
        }

        private void InicializarListas()
        {

            FechaActual();
            EntradaService.UsuariosAlmacen(cmbRecibio, FrmAlmacen.AlmacenActual.IdAlmacen);
            EntradaService.UsuariosAlmacen(cmbSuperviso, FrmAlmacen.AlmacenActual.IdAlmacen);
            EntradaService.CatActividad(cmbActividad);
            EntradaService.CatPresupuesto(cmbPresupuesto);

            Limpiar();
            Inhabilita();
            ResizeGridArticulos();
        }

        private void FechaActual()
        {
            var dtActual = EntradaService.EntradaDao.FechaServidor();
            dtFechaEntrada.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFechaEntrada.Value = dtActual;
            dtFechaEntrada.MinDate = new DateTime(dtActual.Year-1, 1, 1);
        }

        private void ResizeGridArticulos()
        {
            bisEntradaDetalle.DataSource = new List<EntradaDetalle>();
            dgvEntradaDetalle.AutoGenerateColumns = false;
            dgvEntradaDetalle.AllowUserToAddRows = true;
            dgvEntradaDetalle.AllowUserToResizeColumns = false;
            //dgvArticulos0.AutoSize = true;
            dgvEntradaDetalle.DataSource = bisEntradaDetalle;

            DataGridViewColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Clave",
                Name = "Clave",
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            dgvEntradaDetalle.Columns.Add(column);


            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                Name = "Descripción",
                ReadOnly = true,
                Width = 550,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False
            };
            dgvEntradaDetalle.Columns.Add(column);

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
            dgvEntradaDetalle.Columns.Add(column);

           column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                Name = "Cantidad Recibida",
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight , Format = "n"}
            };
            dgvEntradaDetalle.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecioEntrada",
                Name = "Precio Entrada",
                Width = 70,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight , Format = "c"},

            };
            dgvEntradaDetalle.Columns.Add(column);
            
            dgvEntradaDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Limpiar()
        {
            EntradaActual = new Entrada();
            bisEntrada.DataSource = new Entrada();
            bisEntradaDetalle.DataSource = new List<EntradaDetalle>();
           
        }
        private void Habilita()
        {
            txtNumeroEntrada.Enabled = true;
            dtFechaEntrada.Enabled = true;
            txtFactura.Enabled = true;
            cmbActividad.Enabled = true;
            cmbPresupuesto.Enabled = true;
            cmbRecibio.Enabled = true;
            cmbSuperviso.Enabled = true;
            dgvEntradaDetalle.Enabled = true;
        }

        private void Inhabilita()
        {
            txtNumeroEntrada.Enabled = false;
            dtFechaEntrada.Enabled = false;
            txtFactura.Enabled = false;
            cmbActividad.Enabled = false;
            cmbPresupuesto.Enabled = false;
            cmbRecibio.Enabled = false;
            cmbSuperviso.Enabled = false;

            dgvEntradaDetalle.Enabled = false;
            btnGuardar.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private bool TieneRepetidoRenglon(int intCveArt)
        {
            var intTmp = 0;
            for (var i = 0; i < dgvEntradaDetalle.Rows.Count - 1; i++)
            {
                if(Convert.ToInt32(dgvEntradaDetalle[0,i].Value) == intCveArt)
                {
                    intTmp++;
                }
            }
            return intTmp > 1;
        }

        private void CargaFolioNuevo()
        {
            txtNumeroEntrada.Text = EntradaService.EntradaDao.NumeroEntrada(dtFechaEntrada.Value.Year,
                         FrmAlmacen.AlmacenActual.IdAlmacen).ToString();
            txtNumeroEntrada.Focus();
        }
        #endregion

        private void dtFechaEntrada_Validated(object sender, EventArgs e)
        {
            CargaFolioNuevo();
        }

        

    }
}
