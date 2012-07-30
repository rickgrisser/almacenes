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
using Almacen.Business.ModCatalogos;
using Almacen.Business;

namespace Almacen.View
{
    public partial class FrmCatalogoArticulo : Form
    {
        #region Variables Miembro
        public IArticuloService ArticuloService;
        private static Articulo ArticuloActual;
        private static ArticuloFarmacia ArticuloFarmaciaActual;
        private static CatPartida CatPartidaActual;
        //private bool blnAsigna;
        private bool blnModificacion;
        #endregion

        #region Constructores
        public FrmCatalogoArticulo()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            ArticuloService = ctx["articuloService"] as IArticuloService;
            EnlaceDatos();
            InicializarListas();
        }
        #endregion

        

        #region Eventos

        private void txtPartida_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtPartida.TextLength > 0)
                    {
                        CatPartidaActual = ArticuloService.CatPartidaDao.CargaPartida(txtPartida.Text);
                        if (CatPartidaActual != null)
                        {
                            lblDesPartida.Text = CatPartidaActual.DesPartida;
                            txtPartida.Enabled = false;
                            btnGuardar.Enabled = true;
                        }
                        else
                        {
                            lblDesPartida.Text = string.Empty;
                            MessageBox.Show(@"No Existe la Partida, Verifique . . ",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnGuardar.Enabled = false;
                            txtPartida.Focus();
                        }
                    }
                    break;
            }
        }

        private void txtPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtPartida, e);
        }

        private void txtCveArt_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtCveArt.TextLength > 0 && int.Parse(txtCveArt.Text) > 0)
                    {
                        CargaArticulo(int.Parse(txtCveArt.Text));
                    }
                    break;
            }
        }

        private void txtCveArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtCveArt, e);
        }

        private void txtCuadroBasico_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtCuadroBasico, e);
        }

        private void txtCuadroBasico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtCuadroBasico, e);
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtCantidad, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtCantidad, e);
        }

        private void txtGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtGrupo, e);
        }

        private void txtDosis_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtDosis, e);
        }

        private void txtGramaje_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtGramaje, e);
        }

        private void txtMinimo_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtMinimo, e);
        }

        private void txtMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnDecimal(txtMinimo.Text, e);
        }

        private void txtMaximo_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtMaximo, e);
        }

        private void txtMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnDecimal(txtMaximo.Text, e);
        }

        private void txtReorden_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtReorden, e);
        }

        private void txtReorden_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnDecimal(txtReorden.Text, e);
        }

        private void txtArea_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtArea, e);
        }

        private void txtAnaquel_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtAnaquel, e);
        }

        private void txtNivel_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtNivel, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           GuardaArticulo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Inhabilita();
            btnGuardar.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            blnModificacion = true;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = true;
            txtCveArt.Enabled = true;
            txtCveArt.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilita();
            //bisRequisicion.DataSource = new Requisicion();
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            //txtNumeroRequisicion.Text = RequisicionService.RequisicionDao.NumeroRequisicion(RequisicionService.RequisicionDao.FechaServidor().Year,
            //    FrmAlmacen.AlmacenActual.IdAlmacen).ToString();
            //RequisicionService.CargaFallos(cmbLicitacion, dtFechaRequisicion.Value.Year, FrmAlmacen.AlmacenActual.IdAlmacen);
            blnModificacion = false;
            txtPartida.Focus();
        }

        #endregion

        #region Metodos

        private void InicializarListas()
        {
            ArticuloService.Unidades(cmbUnidad);
            ArticuloService.Unidades(cmbPresentacion);
            ArticuloService.Unidades(cmbPresentacionUnidad);
            
           if(FrmAlmacen.AlmacenActual.IdAlmacen.Contains("F"))
            {
                Mostrar();
                ArticuloService.ViaAdministracion(cmbAdministracion);
                ArticuloService.TipoMedicamento(cmbTipoMed);
            }
            else
            {
                this.Height = 375;
            }

           Limpiar();
           Inhabilita();
           btnGuardar.Enabled = false;
           btnAgregar.Enabled = true;
           btnModificar.Enabled = true;
           btnCancelar.Enabled = false;
        }

        private void GuardaArticulo()
        {
            try
            {
                var listaError = new RichTextBox();
                var lblNumErrors = new Label();
                if (blnModificacion)
                { ArticuloUpdate(); }
                else
                { ArticuloSave(); }
                if (Util.DatosValidos2<Articulo>(ArticuloActual, lblNumErrors, listaError))
                {
                    ArticuloService.GuardaArticulo(ref ArticuloActual, blnModificacion, FrmAlmacen.AlmacenActual);
                    MessageBox.Show(@"Articulo Almacenado o Actualizada Exitosamente" +"\r\r" +
                                    @"Clave del Articulo: " + ArticuloActual.Id.CveArt ,
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Inhabilita();
                    btnGuardar.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = false;
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

        private void ArticuloSave()
        {
            try
            {
                ArticuloActual = new Articulo();
                ArticuloActual = bisArticulo.DataSource as Articulo;
                //
                if (FrmAlmacen.AlmacenActual.IdAlmacen.Contains("F"))
                {
                    foreach (ArticuloFarmacia ObjArticuloFarmacia in bisArticuloFarmacia)
                    {
                        var lst = new List<ArticuloFarmacia>(){ObjArticuloFarmacia};
                        ArticuloActual.ArticuloFarmacia = lst;
                    }
                    
                    var objCuadroBasicoId = new CuadroBasicoId()
                    {
                        CveCBasico =txtCuadroBasico.Text.Length!=0?int.Parse(txtCuadroBasico.Text):0,
                        Movimiento = 1
                    };
                    var objCuadroBasico = new CuadroBasico(objCuadroBasicoId)
                    {FechaAlta =ArticuloService.ArticuloDao.FechaServidor()};
                    var lstCuadroBasico = new List<CuadroBasico>() { objCuadroBasico };
                    ArticuloActual.CuadroBasico = lstCuadroBasico;
                }
                //
                var objArticuloPartidaId = new ArticuloPartidaId()
                    {
                        CatPartida = CatPartidaActual,
                        Movimiento = 1
                    };
                var objArticuloPartida = new ArticuloPartida(objArticuloPartidaId)
                    {FechaInicio =  ArticuloService.ArticuloDao.FechaServidor()};
                var lstPartida = new List<ArticuloPartida> {objArticuloPartida};
                ArticuloActual.ArticuloPartida = lstPartida;
                //
                ArticuloActual.Usuario = FrmAcceso.UsuarioLog;
                ArticuloActual.IpTerminal = Util.ipTerminal();
                ArticuloActual.FechaAlta = ArticuloService.ArticuloDao.FechaServidor();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ArticuloUpdate()
        {
            try
            {
                ArticuloActual = new Articulo();
                ArticuloActual = bisArticulo.DataSource as Articulo;

                if (FrmAlmacen.AlmacenActual.IdAlmacen.Contains("F"))
                {
                    foreach (ArticuloFarmacia ObjArticuloFarmacia in bisArticuloFarmacia)
                    {
                        var lst = new List<ArticuloFarmacia>() { ObjArticuloFarmacia };
                        ArticuloActual.ArticuloFarmacia = lst;
                    }
                }
                ArticuloActual.Usuario = FrmAcceso.UsuarioLog;
                ArticuloActual.IpTerminal = Util.ipTerminal();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaArticulo(int intCveArt)
        {
            var objArticulo = ArticuloService.ArticuloDao.CargaArticulo(intCveArt, FrmAlmacen.AlmacenActual.IdAlmacen);
            if(objArticulo!=null)
            {

                bisArticulo.DataSource = objArticulo;
                var objArticuloPartida = ArticuloService.ArticuloPartidaDao.CargaArticuloPartida(
                    objArticulo.Id.CveArt,FrmAlmacen.AlmacenActual.IdAlmacen);
                txtPartida.Text = objArticuloPartida.Id.CatPartida.Partida;
                lblDesPartida.Text = objArticuloPartida.Id.CatPartida.DesPartida;
                if (FrmAlmacen.AlmacenActual.IdAlmacen.Contains("F"))
                {

                    foreach (var objArticuloFarmacia in objArticulo.ArticuloFarmacia)
                    {
                        bisArticuloFarmacia.DataSource = objArticuloFarmacia;
                        break;
                    }


                    foreach (var objCuadroBasico in objArticulo.CuadroBasico)
                    {
                        txtCuadroBasico.Text = objCuadroBasico.Id.CveCBasico.ToString();
                        break;
                    }

                }
                
                txtCveArt.Enabled = false;
                Habilita();
                txtPartida.Enabled = false;
                txtCuadroBasico.Enabled = false;
                btnGuardar.Enabled = true;
            }
            else
            {
                bisArticulo.DataSource = new Articulo();
                MessageBox.Show(@"Articulo No Existe",
                                       @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EnlaceDatos()
        {
            rtbDesArticulo.DataBindings.Add(new Binding("Text", bisArticulo, "DesArticulo", true));
            cmbUnidad.DataBindings.Add(new Binding("Text", bisArticulo, "CatUnidad", true));
            cmbPresentacion.DataBindings.Add(new Binding("Text", bisArticulo, "Presentacion", true));
            txtCantidad.DataBindings.Add(new Binding("Text", bisArticulo, "PresentacionCant", true));
            cmbPresentacionUnidad.DataBindings.Add(new Binding("Text", bisArticulo, "PresentacionUnid", true));
            txtMaximo.DataBindings.Add(new Binding("Text", bisArticulo, "Maximo", true));
            txtMinimo.DataBindings.Add(new Binding("Text", bisArticulo, "Minimo", true));
            txtReorden.DataBindings.Add(new Binding("Text", bisArticulo, "PuntoReorden", true));
            txtArea.DataBindings.Add(new Binding("Text", bisArticulo, "AreaLocaliza", true));
            txtAnaquel.DataBindings.Add(new Binding("Text", bisArticulo, "AnaquelLocaliza", true));
            txtNivel.DataBindings.Add(new Binding("Text", bisArticulo, "NivelLocaliza", true));
            ArticuloActual = new Articulo();
            bisArticulo.DataSource = ArticuloActual;

            cmbAdministracion.DataBindings.Add(new Binding("SelectedValue", bisArticuloFarmacia, "ViaAdministracion", true));
            cmbTipoMed.DataBindings.Add(new Binding("SelectedValue", bisArticuloFarmacia, "TipoMedicamento", true));
            txtGrupo.DataBindings.Add(new Binding("Text", bisArticuloFarmacia, "Grupo", true));
            txtDosis.DataBindings.Add(new Binding("Text", bisArticuloFarmacia, "Dosis", true));
            txtGramaje.DataBindings.Add(new Binding("Text", bisArticuloFarmacia, "Gramaje", true));
            ArticuloFarmaciaActual = new ArticuloFarmacia();
            bisArticuloFarmacia.DataSource = ArticuloFarmaciaActual;
        }

        private void Mostrar()
        {
            lblCuadroBasico.Visible = true;
            txtCuadroBasico.Visible = true;

            lblAdmistracion.Visible = true;
            cmbAdministracion.Visible = true;
            lblTipoMed.Visible = true;
            cmbTipoMed.Visible = true;

            lblGrupo.Visible = true;
            lblDosis.Visible = true;
            lblGramaje.Visible = true;

            txtGrupo.Visible = true;
            txtDosis.Visible = true;
            txtGramaje.Visible = true;
            
        }
        private void Limpiar()
        {
            ArticuloActual= new Articulo();
            ArticuloFarmaciaActual = new ArticuloFarmacia();
           
            CatPartidaActual= new CatPartida();

            bisArticulo.DataSource = new Articulo();
            bisArticuloFarmacia.DataSource = new ArticuloFarmacia();
           
            txtPartida.Text = string.Empty;
            lblDesPartida.Text = string.Empty;
            txtCveArt.Text = string.Empty;
            txtCuadroBasico.Text = string.Empty;
        }
        private void Habilita()
        {
            txtPartida.Enabled = true;
            //txtCveArt.Enabled = true;
            rtbDesArticulo.Enabled = true;
            txtCuadroBasico.Enabled = true;
            txtCantidad.Enabled = true;
            txtGrupo.Enabled = true;
            txtDosis.Enabled = true;
            txtGramaje.Enabled = true;
            txtMinimo.Enabled = true;
            txtMaximo.Enabled = true;
            txtReorden.Enabled = true;
            txtArea.Enabled = true;
            txtAnaquel.Enabled = true;
            txtNivel.Enabled = true;

            cmbAdministracion.Enabled = true;
            cmbPresentacion.Enabled = true;
            cmbPresentacionUnidad.Enabled = true;
            cmbTipoMed.Enabled = true;
            cmbUnidad.Enabled = true;
        }

        private void Inhabilita()
        {
            txtPartida.Enabled = false;
            txtCveArt.Enabled = false;
            rtbDesArticulo.Enabled = false;
            txtCuadroBasico.Enabled = false;
            txtCantidad.Enabled = false;
            txtGrupo.Enabled = false;
            txtDosis.Enabled = false;
            txtGramaje.Enabled = false;
            txtMinimo.Enabled = false;
            txtMaximo.Enabled = false;
            txtReorden.Enabled = false;
            txtArea.Enabled = false;
            txtAnaquel.Enabled = false;
            txtNivel.Enabled = false;

            cmbAdministracion.Enabled = false;
            cmbPresentacion.Enabled = false;
            cmbPresentacionUnidad.Enabled = false;
            cmbTipoMed.Enabled = false;
            cmbUnidad.Enabled = false;

            }
        #endregion

        

        

        

        

    }
}
