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
    public partial class FrmCatArticuloCambiar : Form
    {
        #region Variables Miembro
        public IArticuloCambiarService ArticuloCambiarService;
        private ArticuloPartida ArticuloPartidaActual;
        private CuadroBasico CuadroBasicoActual;
        private CatPartida CatPartidaActual;
        public bool BlnOption;
        #endregion

        #region Constructores
        public FrmCatArticuloCambiar()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            ArticuloCambiarService = ctx["articulocambiarService"] as IArticuloCambiarService;
            //EnlaceDatos();
            InicializarListas();
        }

        private void FrmCatArticuloCambiar_Load(object sender, EventArgs e)
        {
            if (BlnOption)
            {
                lblCuadroBasico.Visible = true;
                txtCuadroBasico.Visible = true;
            }
            else
            {
                lblPartida.Visible = true;
                lblDesPartida.Visible = true;
                txtPartida.Visible = true;
            }
        }
        #endregion

        #region Eventos

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
                        if(BlnOption)
                        {
                            CargaCuadroBasico();   
                        }
                        else
                        {
                            CargaArticuloPartida();
                        }
                    }
                    break;
            }
        }

        private void txtCveArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtCveArt, e);
        }

        private void txtPartida_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtPartida.TextLength > 0 && int.Parse(txtPartida.Text) > 0)
                    {
                        if (txtPartida.TextLength > 0)
                        {
                            CatPartidaActual = ArticuloCambiarService.CatPartidaDao.CargaPartida(txtPartida.Text);
                            if (CatPartidaActual != null)
                            {
                                lblDesPartida.Text = CatPartidaActual.DesPartida;
                                txtPartida.Enabled = false;
                                btnGuardar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show(@"No Existe la Partida, Verifique . . ",
                                         @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnGuardar.Enabled = false;
                                txtPartida.Focus();
                            }
                        }
                    }
                    break;
            }
        }

        private void txtPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtPartida, e);
        }

        private void txtCuadroBasico_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtCuadroBasico, e);
        }

        private void txtCuadroBasico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtPartida, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(BlnOption)
            {
                GuardaCuadroBasico();
            }
            else
            {
                GuardaPartida();
            }
        }

       private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            txtCveArt.Enabled = true;
            txtCveArt.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Inhabilita();
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        #endregion

        #region Metodos

        private void GuardaPartida()
        {
            try
            {
                ArticuloPartidaActual.FechaFin = ArticuloCambiarService.ArticuloPartidaDao.FechaServidor();
                ArticuloCambiarService.GuardaArticuloPartida(ref CatPartidaActual, ref ArticuloPartidaActual);
                    
                MessageBox.Show(@"Cambio de Partida Actualizada Exitosamente" ,
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                Inhabilita();
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GuardaCuadroBasico()
        {
            try
            {
                CuadroBasicoActual.FechaBaja = ArticuloCambiarService.ArticuloPartidaDao.FechaServidor();
                var CuadroBascioId = new CuadroBasicoId()
                {
                    CveCBasico = int.Parse(txtCuadroBasico.Text),
                    Articulo = CuadroBasicoActual.Id.Articulo,
                    Movimiento = CuadroBasicoActual.Id.Movimiento + 1
                };
                var CuadroBasicoNuevo = new CuadroBasico(CuadroBascioId)
                {
                    FechaAlta = ArticuloCambiarService.ArticuloPartidaDao.FechaServidor()
                };

                var listaError = new RichTextBox();
                var lblNumErrors = new Label();
                if (Util.DatosValidos2<CuadroBasico>(CuadroBasicoNuevo, lblNumErrors, listaError))
                {

                    ArticuloCambiarService.GuardaCuadroBasico(ref CuadroBasicoActual, ref CuadroBasicoNuevo);
                    MessageBox.Show(@"Cambio de Cuadro Basico Actualizado Exitosamente",
                               @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                    Inhabilita();
                    btnGuardar.Enabled = false;
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
         
        private void CargaArticuloPartida()
        {
            ArticuloPartidaActual = ArticuloCambiarService.ArticuloPartidaDao.
                            CargaArticuloPartidaCambiarPartida(int.Parse(txtCveArt.Text), FrmAlmacen.AlmacenActual.IdAlmacen);
            if (ArticuloPartidaActual != null)
            {
                rtbDesArticulo.Text = ArticuloPartidaActual.Id.Articulo.DesArticulo;
                txtPartida.Text = ArticuloPartidaActual.Id.CatPartida.Partida;
                lblDesPartida.Text = ArticuloPartidaActual.Id.CatPartida.DesPartida;
                txtCveArt.Enabled = false;
                txtPartida.Enabled = true;
                btnModificar.Enabled = false;

            }
            else
            {
                MessageBox.Show(@"Articulo No Existe",
                          @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargaCuadroBasico()
        {
            CuadroBasicoActual = ArticuloCambiarService.CuadroBasicoDao.
                CargaCuadroBasico(int.Parse(txtCveArt.Text),FrmAlmacen.AlmacenActual.IdAlmacen);
            if(CuadroBasicoActual!=null)
            {
                rtbDesArticulo.Text = CuadroBasicoActual.Id.Articulo.DesArticulo;
                txtCuadroBasico.Text = CuadroBasicoActual.Id.CveCBasico.ToString();
                txtCveArt.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = true;
                txtCuadroBasico.Enabled = true;
            }
            else
            {
                MessageBox.Show(@"Articulo No Existe",
                          @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void InicializarListas()
        {
            Limpiar();
            Inhabilita();
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
            this.Height = 200;
        }

        private void Limpiar()
        {

            ArticuloPartidaActual = new ArticuloPartida();
            CuadroBasicoActual = new CuadroBasico();
            
            txtCveArt.Text = string.Empty;
            rtbDesArticulo.Text = string.Empty;
            txtCuadroBasico.Text = string.Empty;
            txtPartida.Text = string.Empty;
            txtPartida.Text = string.Empty;
            lblDesPartida.Text = string.Empty;
        }

        private void Inhabilita()
        {
            txtCveArt.Enabled = false;
            rtbDesArticulo.Enabled = false;
            txtCuadroBasico.Enabled = false;
            txtPartida.Enabled = false;
        }

        private void Habilita()
        {
            txtCveArt.Enabled = true;
            rtbDesArticulo.Enabled = true;
            txtCuadroBasico.Enabled = true;
            txtPartida.Enabled = true;
        }
        #endregion

       

       

        

       
    }
}
