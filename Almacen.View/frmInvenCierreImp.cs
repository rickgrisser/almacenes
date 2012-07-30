using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Almacen.Business.ModCierre;
using Almacen.Data.Entities;
using Almacen.Data.RptsClass;
using Spring.Context;
using Spring.Context.Support;

namespace Almacen.View
{
    public partial class FrmInvenCierreImp : Form
    {
        #region Variables Miembro
        private ICierreService CierreService;
        private CatPartida CatPartidaActual;
        #endregion
        
        #region Constructores
        public FrmInvenCierreImp()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            CierreService = ctx["cierreService"] as ICierreService;
            InicializarListas();
        }
        #endregion

        #region Eventos
        private void cmbAnio_ValueChanged(object sender, EventArgs e)
        {
            CargaMeses();
        }

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
                        CatPartidaActual = CierreService.CatPartidaDao.CargaPartida(txtPartida.Text);
                        if (CatPartidaActual != null)
                        {
                            lblDesPartida.Text = CatPartidaActual.DesPartida;
                            txtPartida.Enabled = false;
                        }
                        else
                        {
                            lblDesPartida.Text = string.Empty;
                            MessageBox.Show(@"No Existe la Partida, Verifique . . ",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimeCierre();
        }

        #endregion

        #region Metodos

        private void ImprimeCierre()
        {
            var cierres = CatPartidaActual == null? 
                CierreService.CierreDao.RptCierre((int)cmbMes.SelectedValue,(int)cmbAnio.Value,
                FrmAlmacen.AlmacenActual.IdAlmacen,rbtnCExistencia.Checked):
                CierreService.CierreDao.RptCierreXPartida((int)cmbMes.SelectedValue, (int)cmbAnio.Value,
                FrmAlmacen.AlmacenActual.IdAlmacen, CatPartidaActual.Partida, rbtnCExistencia.Checked);

            if (cierres.Count != 0)
            {
                var lstCierre = new List<rptDataCierre>();
                foreach (var cierre in cierres)
                {
                    var newCierre = new rptDataCierre()
                    {
                        FechaCierre = DateTime.Parse(cierre[5].ToString()),
                        CveArt = (int)cierre[0],
                        DesArticulo = cierre[1].ToString(),
                        Medida = cierre[2].ToString(),
                        Existencia = Convert.ToDouble(cierre[3]),
                        Costo = Convert.ToDouble(cierre[4]),
                        CvePartida = cierre[6].ToString(),
                        DesPartida = cierre[7].ToString()

                    };
                    lstCierre.Add(newCierre);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstCierre,
                    StrRptName = "rptCierre",
                    StrTitle = "ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                };
                formaVisor.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"No Existe Cierre, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        private void InicializarListas()
        {
            var dtFechaActual = CierreService.CierreDao.FechaServidor();
            cmbAnio.Maximum = dtFechaActual.Year;
            cmbAnio.Value = dtFechaActual.Year;
            cmbAnio.Minimum = dtFechaActual.Year - 1;
            lblDesPartida.Text = string.Empty;
            CargaMeses();
        }

        private void CargaMeses()
        {
            var lstFechas = CierreService.CierreDao.CargaFechasCierres((int)cmbAnio.Value, FrmAlmacen.AlmacenActual.IdAlmacen);
            if (lstFechas.Count > 0)
            {
                var listItem = new List<Item>();
                foreach (var lstFecha in lstFechas)
                {
                    var Item = new Item(Fx.NombreMes(lstFecha.Month), lstFecha.Month);
                    listItem.Add(Item);
                }

                cmbMes.DisplayMember = "Name";
                cmbMes.ValueMember = "Value";
                cmbMes.DataSource = listItem;
                cmbMes.SelectedIndex = 0;
                btnImprimir.Enabled = true;
            }
            else
            {
                cmbMes.DataSource = new List<Item>();
                btnImprimir.Enabled = false;
            }

        }

        #endregion
        
    }
}
