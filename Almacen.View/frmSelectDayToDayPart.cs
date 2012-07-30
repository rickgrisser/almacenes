using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Almacen.Business.ModEntrada;
//using Almacen.Business.ModSalida;
using Almacen.Data.Entities;
using Almacen.Data.RptsClass;
using Spring.Context;
using Spring.Context.Support;

namespace Almacen.View
{
    public partial class FrmSelectDayToDayPart : Form
    {
        #region Variables Miembro

        public string strOpcion;
        private IEntradaService EntradaService;
        //private ISalidaService SalidaService;
        private CatPartida CatPartidaActual;
        #endregion

        #region Contructores
        public FrmSelectDayToDayPart()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            EntradaService = ctx["entradaService"] as IEntradaService;
            //SalidaService = ctx["salidaService"] as ISalidaService;
            InicializarListas();
        }
        #endregion

        #region Eventos

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(dtFechaFin.Value>=dtFechaIni.Value)
            {
                switch (strOpcion)
                {
                    case "EntradaIFAI":
                        ImprimeEntradaIFAI();
                        break;
                    //case "SalidaPartida":
                    //    ImprimeSalidaPartida();
                    //    break;
                }
            }
            else
            {
                MessageBox.Show(@"La Fecha Final Debe Ser Mayor a Fecha Inicial, Verifique . .",
                               @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        CatPartidaActual = EntradaService.CatPartidaDao.CargaPartida(txtPartida.Text);
                        if (CatPartidaActual != null)
                        {
                            lblDesPartida.Text = CatPartidaActual.DesPartida;
                            txtPartida.Enabled = false;
                            btnImprimir.Enabled = true;
                        }
                        else
                        {
                            lblDesPartida.Text = string.Empty;
                            MessageBox.Show(@"No Existe la Partida, Verifique . . ",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPartida.Focus();
                            btnImprimir.Enabled = false;
                        }
                    }
                    break;
            }
        }

        private void txtPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtPartida, e);
        }

        #endregion

        #region Metodos
        private void InicializarListas()
        {
            var dtActual = EntradaService.EntradaDao.FechaServidor();
            dtFechaIni.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFechaIni.Value = dtActual;
            dtFechaIni.MinDate = new DateTime(dtActual.Year-1, 1, 1);

            dtFechaFin.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFechaFin.Value = dtActual;
            dtFechaFin.MinDate = new DateTime(dtActual.Year-1, 1, 1);

            lblDesPartida.Text = string.Empty;
        }

        private void ImprimeEntradaIFAI()
        {
            var entradaDetalles = EntradaService.EntradaDetalleDao.RptEntradaIFAI
                    (dtFechaIni.Value,dtFechaFin.Value,FrmAlmacen.AlmacenActual, CatPartidaActual);

            if (entradaDetalles.Count != 0)
            {
                var lstEntradaIFAI = new List<rptDataEntradaIFAI>();
                foreach (var entradaDetalle in entradaDetalles)
                {
                    var entradaVale = new rptDataEntradaIFAI()
                    {
                        FechaIni = dtFechaIni.Value,
                        FechaFin = dtFechaFin.Value,
                        CvePartida = CatPartidaActual.Partida,
                        DesPartida = CatPartidaActual.DesPartida,
                        CuadroBasico = entradaDetalle[0]==null?"S/C BASICO":entradaDetalle[0].ToString(),
                        CveArt = (int)entradaDetalle[1],
                        DesArticulo = entradaDetalle[2].ToString(),
                        Unidad = entradaDetalle[3].ToString(),
                        Cantidad = Convert.ToDouble(entradaDetalle[4]),
                        PrecioUnitario = Convert.ToDouble(entradaDetalle[5]),
                        Factura = entradaDetalle[6].ToString(),
                        NumPedido = entradaDetalle[7]==null?-1:(long)entradaDetalle[7],
                        DesProveedor = entradaDetalle[8]==null?"":entradaDetalle[8].ToString(),
                        Licitacion = entradaDetalle[9] == null ? "" : entradaDetalle[9].ToString(),
                        TipoAdquisicion = entradaDetalle[10] == null ? "" : entradaDetalle[10].ToString()
                    };
                    lstEntradaIFAI.Add(entradaVale);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstEntradaIFAI,
                    StrRptName = "rptEntradaIFAI",
                    StrTitle = "ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                };
                formaVisor.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"No Existen Entradas, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     
        #endregion

       

    }
}
