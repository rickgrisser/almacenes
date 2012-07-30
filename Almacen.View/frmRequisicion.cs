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
using Almacen.Business.ModRequisicion;
using Almacen.Business;

namespace Almacen.View
{
    public partial class FrmRequisicion : Form
    {
         #region Variables Miembro
        public IRequisicionService RequisicionService;
        private static Requisicion RequisicionActual;
        //private static Requisicion RequisicionActualModificacion;
        private bool blnModificacion;
        
        #endregion

        #region Constructores
        public FrmRequisicion()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            RequisicionService = ctx["requisicionService"] as IRequisicionService;
            EnlaceDatos();
            InicializarListas();
        }
        #endregion

        #region Eventos

        private void txtNumeroRequisicion_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtNumeroRequisicion.TextLength > 0 && blnModificacion && int.Parse(txtNumeroRequisicion.Text) > 0)
                    {
                        CargaRequisicion(int.Parse(txtNumeroRequisicion.Text));
                    }
                    break;
            }
        }

        private void txtNumeroRequisicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtNumeroRequisicion, e);
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
                        cmbArea.DataSource = new List<CatArea>();
                        RequisicionService.CargaArea(cmbArea, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
                                                           int.Parse(txtCveArea.Text));
                        if (cmbArea.Items.Count == 0)
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
                        RequisicionService.CargaAreas(cmbArea, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
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

        private void txtAbasto_KeyDown(object sender, KeyEventArgs e)
        {
            //Simple Tab = Enter
            Fx.OnKeyTab(txtAbasto, e);
        }

        private void txtAbasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtAbasto, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNumeroRequisicion.Text) == 0)
            {
                MessageBox.Show(@"El Numero de Requisicion NO Puede ser '0', Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (blnModificacion)
                {
                    foreach (FalloDetalle objFallo in bisFalloDetalle)
                    {
                        if (objFallo.Requisicion > 0)
                        {
                            var objRequisicionDetalle = new RequisicionDetall()
                            {
                                Articulo = objFallo.Articulo,
                                Cantidad = objFallo.Requisicion
                            };

                            bisRequisicionDetalle.Add(objRequisicionDetalle);
                        }
                    }
                    GuardaRequisicion();
                }
                else
                {
                    if (RequisicionService.RequisicionDao.RequisicionExiste(dtFechaRequisicion.Value.Year,
                                                                            FrmAlmacen.AlmacenActual.IdAlmacen,
                                                                            int.Parse(txtNumeroRequisicion.Text)))
                    {
                        MessageBox.Show(@"El Numero de Salida Ya Existe, Verifique . .",
                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        foreach (FalloDetalle objFallo in bisFalloDetalle)
                        {
                            if (objFallo.Requisicion > 0)
                            {
                                var objRequisicionDetalle = new RequisicionDetall()
                                                                {
                                                                    Articulo = objFallo.Articulo,
                                                                    Cantidad = objFallo.Requisicion
                                                                };

                                bisRequisicionDetalle.Add(objRequisicionDetalle);
                            }
                        }
                        GuardaRequisicion();
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilita();
            FechaActual();
            bisRequisicion.DataSource = new Requisicion();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            CargaFolioNuevo();
            RequisicionService.CargaFallos(cmbLicitacion, dtFechaRequisicion.Value.Year, FrmAlmacen.AlmacenActual.IdAlmacen);
            blnModificacion = false;
            txtNumeroRequisicion.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            blnModificacion = true;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
            RequisicionService.CargaFallos(cmbLicitacion, dtFechaRequisicion.Value.Year, FrmAlmacen.AlmacenActual.IdAlmacen);
            txtNumeroRequisicion.Enabled = true;
            txtNumeroRequisicion.Focus();
            FechaActual();
            dtFechaRequisicion.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Inhabilita();
        }

       

        private void cmbLicitacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargaArticulos();
        }

        private void dgvArticulos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvArticulos.CurrentCell.ColumnIndex == 5)
            {
                var txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= dgvArticulos_KeyPress;
                    txt.KeyPress += dgvArticulos_KeyPress;
                }
            }
        }

        private void dgvArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvArticulos.CurrentCell.ColumnIndex == 5)
            {
                Fx.OnDecimal(dgvArticulos[
                    dgvArticulos.CurrentCell.ColumnIndex, dgvArticulos.CurrentCell.RowIndex].EditedFormattedValue, e);
            }
        }

        private void dgvArticulos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvArticulos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Para realizar las validaciones
            try
            {
                if (e.ColumnIndex == 5)
                {
                    if (Convert.ToDecimal(dgvArticulos[e.ColumnIndex, e.RowIndex].Value) > 
                        (Convert.ToDecimal(dgvArticulos[3, e.RowIndex].Value) - Convert.ToDecimal(dgvArticulos[4, e.RowIndex].Value)))
                    {
                        MessageBox.Show(@"Existencia Insuficiente, Verifique . .",
                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvArticulos[e.ColumnIndex, e.RowIndex].Value ="0";
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion del Articulo " + ee.Message,
                     @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int intCol;
            if (e.ColumnIndex == 3)
            {
                var intPor = Fx.Porcentaje(Convert.ToDouble(dgvArticulos[3, e.RowIndex].Value),
                                        Convert.ToDouble(dgvArticulos[4, e.RowIndex].Value));
                switch (intPor)
                {
                    case 80:
                    case 81:
                    case 82:
                    case 83:
                    case 84:
                    case 85:
                    case 86:
                    case 87:
                    case 88:
                    case 89:
                    case 90:
                    case 91:
                    case 92:
                    case 93:
                    case 94:
                    case 95:
                    case 96:
                    case 97:
                    case 98:
                    case 99:
                        for (intCol = 0; intCol < dgvArticulos.ColumnCount; intCol++)
                        {
                            dgvArticulos.Rows[e.RowIndex].Cells[intCol].Style.BackColor = Color.LightGoldenrodYellow;
                        }
                        break;
                    case 100:
                        for (intCol = 0; intCol < dgvArticulos.ColumnCount; intCol++)
                        {
                            dgvArticulos.Rows[e.RowIndex].Cells[intCol].Style.BackColor = Color.LightSalmon;
                        }
                        break;
                    default:
                        //for(intCol=0;intCol<dgvArticulos.ColumnCount;intCol++)
                        //{
                        //    dgvArticulos.Rows[e.RowIndex].Cells[intCol].Style.BackColor = Color;
                        //}
                        break;
                }
            }
        }

        #endregion

        #region Metodos

        private void CargaFallos()
        {
            cmbLicitacion.DataSource = null;
            RequisicionService.CargaFallos(cmbLicitacion, dtFechaRequisicion.Value.Year, FrmAlmacen.AlmacenActual.IdAlmacen);
        }

        private void GuardaRequisicion()
        {
            try
            {
                var listaError = new RichTextBox();
                var lblNumErrors = new Label();
                if (blnModificacion)
                { RequisicionUpdate(); }
                else
                { RequisicionSave(); }
                if (Util.DatosValidos2<Requisicion>(RequisicionActual, lblNumErrors, listaError))
                {

                    //if (blnModificacion)
                    //{
                        //SalidaActualModificacion = SalidaService.SalidaDao.CargaSalida(SalidaService.SalidaDao.FechaServidor().Year,
                        //    FrmAlmacen.AlmacenActual.IdAlmacen, Convert.ToInt16(txtNumeroSalida.Text), FrmAcceso.UsuarioLog.IdUsuario);
                        //SalidaService.BorraSalida(ref SalidaActualModificacion);
                    //}

                    RequisicionService.GuardaRequisicion(ref RequisicionActual, blnModificacion);
                    MessageBox.Show(@"Requisicion Almacenada o Actualizada Exitosamente",
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

        private void RequisicionSave()
        {
            try
            {
                RequisicionActual = new Requisicion();
                RequisicionActual = bisRequisicion.DataSource as Requisicion;
                RequisicionActual.RequisicionDetall = bisRequisicionDetalle.DataSource as List<RequisicionDetall>;
                var objTmp = cmbLicitacion.SelectedValue as object[];
                RequisicionActual.Anexo = RequisicionService.AnexoDao.Get((long)objTmp[1]);
                RequisicionActual.FechaRequisicion = dtFechaRequisicion.Value;
                RequisicionActual.Estatus = "A";
                RequisicionActual.CatArea = cmbArea.SelectedValue as CatArea;
                RequisicionActual.Usuario = FrmAcceso.UsuarioLog;
                RequisicionActual.Almacen = FrmAlmacen.AlmacenActual;
                RequisicionActual.IpTerminal = Util.ipTerminal();
                RequisicionActual.FechaAlta = RequisicionService.RequisicionDao.FechaServidor();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequisicionUpdate()
        {
            try
            {
                RequisicionActual = new Requisicion();
                RequisicionActual = bisRequisicion.DataSource as Requisicion;
                RequisicionActual.RequisicionDetall = bisRequisicionDetalle.DataSource as List<RequisicionDetall>;
                RequisicionActual.CatArea = cmbArea.SelectedValue as CatArea;
                RequisicionActual.Usuario = FrmAcceso.UsuarioLog;
                RequisicionActual.IpTerminal = Util.ipTerminal();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaRequisicion(int intNumRequisicion)
        {
            RequisicionActual =RequisicionService.RequisicionDao.CargaRequisicion(dtFechaRequisicion.Value.Year,FrmAlmacen.AlmacenActual.IdAlmacen, intNumRequisicion);
            if (RequisicionActual!=null)
            {
                bisRequisicion.DataSource = RequisicionActual;
                cmbLicitacion.SelectedIndex= cmbLicitacion.FindStringExact(RequisicionActual.Anexo.NumeroAnexo.Trim());

                CargaArticulos();
                
                RequisicionService.CargaArea(cmbArea, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
                   RequisicionActual.CatArea.CveArea);

                if (RequisicionActual.Estatus=="A")
                {
                    txtNumeroRequisicion.Enabled = false;
                    txtCveArea.Enabled = true;
                    cmbArea.Enabled = true;
                    txtAbasto.Enabled = true;
                    btnGuardar.Enabled = true;
                    dgvArticulos.Enabled = true;
                }
                else
                {
                    txtNumeroRequisicion.Enabled = false;
                    MessageBox.Show(@"Ya Existe Pedido, No Puede Modificar la Requisición . . ",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnCancelar.Enabled = true;
                dtFechaRequisicion.Enabled = false;
            }
            else
            {
                MessageBox.Show(@"El Numero de Requisicion No Existe o Esta Cancelada, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargaArticulos()
        {
            if (cmbLicitacion.Items.Count > 0)
            {
                dtFechaRequisicion.Enabled = false;
                var objTmp = cmbLicitacion.SelectedValue as object[];
                if(blnModificacion)
                {
                    var bisTmp = RequisicionService.CargaRequisicion((long)objTmp[1], RequisicionActual.IdRequisicion);
                    bisFalloDetalle.DataSource = bisTmp;
                }
                else
                {
                    bisFalloDetalle.DataSource = RequisicionService.FalloDetalleDao.CargaFalloDetalles((long)objTmp[1]);
                }
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void EnlaceDatos()
        {
            txtNumeroRequisicion.DataBindings.Add(new Binding("Text", bisRequisicion, "NumeroRequisicion", true));
            dtFechaRequisicion.DataBindings.Add(new Binding("Value", bisRequisicion, "FechaRequisicion", true));
            //cmbArea.DataBindings.Add(new Binding("SelectedValue", bisRequisicion, "CatArea", true));
            txtAbasto.DataBindings.Add(new Binding("Text", bisRequisicion, "DuracionAbastc", true));
            RequisicionActual = new Requisicion();
            bisRequisicion.DataSource = RequisicionActual;
        }

        private void InicializarListas()
        {
            FechaActual();
            Limpiar();
            Inhabilita();
            ResizeGridArticulos();
        }

        private void ResizeGridArticulos()
        {
            bisFalloDetalle.DataSource = new List<FalloDetalle>();
            dgvArticulos.AutoGenerateColumns = false;
            dgvArticulos.AllowUserToResizeColumns = false;
            //dgvArticulos0.AutoSize = true;
            dgvArticulos.DataSource = bisFalloDetalle;

            DataGridViewColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Clave",
                Name = "Clave",
                ReadOnly = true,
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            dgvArticulos.Columns.Add(column);


            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                Name = "Descripción",
                ReadOnly = true,
                Width = 550,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False
            };
            dgvArticulos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Unidad",
                Name = "Unidad",
                ReadOnly = true,
                Width = 110,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            dgvArticulos.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CantidadMin",
                Name = "Cantidad Minima",
                ReadOnly = true,
                Width = 75,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n" }
            };
            dgvArticulos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CantidadPed",
                Name = "Cantidad Pedida",
                ReadOnly = true,
                Width = 75,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n" }
            };
            dgvArticulos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Requisicion",
                Name = "Requisicion",
                Width = 75,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n" }
            };
            dgvArticulos.Columns.Add(column);

            dgvArticulos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void Limpiar()
        {
            RequisicionActual = new Requisicion();
            bisRequisicion.DataSource = new Requisicion();
            bisRequisicionDetalle.DataSource = new List<RequisicionDetall>();
            bisFalloDetalle.DataSource = new List<FalloDetalle>();
            txtCveArea.Text = string.Empty;
            
            cmbLicitacion.DataSource = new List<int>();
            cmbArea.DataSource = new List<CatArea>();
        }

        private void FechaActual()
        {
            var dtActual = RequisicionService.RequisicionDao.FechaServidor();
            dtFechaRequisicion.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFechaRequisicion.Value = dtActual;
            dtFechaRequisicion.MinDate = new DateTime(dtActual.Year-1, 1, 1);
        }

        private void Habilita()
        {
            txtNumeroRequisicion.Enabled = true;
            dtFechaRequisicion.Enabled = true;
            
            txtCveArea.Enabled = true;
            cmbArea.Enabled = true;

            cmbLicitacion.Enabled = true;
            txtAbasto.Enabled = true;
            dgvArticulos.Enabled = true;

        }

        private void Inhabilita()
        {
            txtNumeroRequisicion.Enabled = false;
            dtFechaRequisicion.Enabled = false;
            
            txtCveArea.Enabled = false;
            cmbArea.Enabled = false;

            cmbLicitacion.Enabled = false;
            txtAbasto.Enabled = false;

            dgvArticulos.Enabled = false;
            btnGuardar.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void CargaFolioNuevo()
        {
            txtNumeroRequisicion.Text = RequisicionService.RequisicionDao.NumeroRequisicion(dtFechaRequisicion.Value.Year,
                FrmAlmacen.AlmacenActual.IdAlmacen).ToString();
            txtNumeroRequisicion.Focus();
        }
        #endregion

        private void dtFechaRequisicion_Validated(object sender, EventArgs e)
        {
            CargaFallos();
            CargaFolioNuevo();
            
        }

       

       

       



                
    }
}
