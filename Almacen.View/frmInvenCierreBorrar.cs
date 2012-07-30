using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Spring.Context;
using Spring.Context.Support;
using Almacen.Business.ModCierre;

namespace Almacen.View
{
    public partial class FrmInvenCierreBorrar : Form
    {
        #region Variables Miembro
        public ICierreBorrarService CierreBorrarService;
        #endregion

        #region Constructores

        public FrmInvenCierreBorrar()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            CierreBorrarService = ctx["cierreborrarService"] as ICierreBorrarService;
            InicializarListas();
        }

        #endregion

        #region Eventos

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbAnioEntrada_ValueChanged(object sender, EventArgs e)
        {
            CargaMeses();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var dtUltimaFecha = CierreBorrarService.CierreDao.CargaUltimaFecha(FrmAlmacen.AlmacenActual.IdAlmacen);
            if (cmbAnio.Value == dtUltimaFecha.Year && (int)cmbMes.SelectedValue == dtUltimaFecha.Month)
            {
                if (dtUltimaFecha.Day == Fx.UltimoDiaMes(dtUltimaFecha).Day)
                {
                    MessageBox.Show(@"Es Cierre de Mes, No se Puede Borrar . .",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BorrarCierre(dtUltimaFecha);
                }
            }
            else
            {
                MessageBox.Show(@"Seleccione el Ultimo Cierre, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Metodos
        private void InicializarListas()
        {
            var dtFechaActual = CierreBorrarService.CierreDao.FechaServidor();
            cmbAnio.Maximum = dtFechaActual.Year;
            cmbAnio.Value = dtFechaActual.Year;
            cmbAnio.Minimum = dtFechaActual.Year - 1;
            CargaMeses();
        }

        private void CargaMeses()
        {
            var lstFechas = CierreBorrarService.CierreDao.CargaFechasCierres((int)cmbAnio.Value, FrmAlmacen.AlmacenActual.IdAlmacen);
            if (lstFechas.Count>0)
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
                btnBorrar.Enabled = true;
            }
            else
            {
                cmbMes.DataSource= new List<Item>();
                btnBorrar.Enabled = false;
            }
            
        }
        
        private void BorrarCierre(DateTime dtUltimaFecha)
        {
            try
            {
                var lstCierre =
                        CierreBorrarService.CierreDao.CargaCierreXAlmacen(FrmAlmacen.AlmacenActual.IdAlmacen,
                                                                            dtUltimaFecha.Month, dtUltimaFecha.Year);
                CierreBorrarService.BorraCierre(ref lstCierre);
                MessageBox.Show(@"Cierre Borrado Exitosamente",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargaMeses();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
