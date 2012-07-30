using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Almacen.Business.ModEntrada;
using Almacen.Business.ModSalida;
using Almacen.Data.RptsClass;
using Spring.Context;
using Spring.Context.Support;

namespace Almacen.View
{
    public partial class FrmSelectDayToDay : Form
    {
        #region Variables Miembro

        public string strOpcion;
        private IEntradaService EntradaService;
        private ISalidaService SalidaService;
        #endregion

        #region Contructores
        public FrmSelectDayToDay()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            EntradaService = ctx["entradaService"] as IEntradaService;
            SalidaService = ctx["salidaService"] as ISalidaService;
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
                    case "EntradaPartida":
                        ImprimeEntradaPartida();
                        break;
                    case "EntradaFolioPartida":
                        ImprimeEntradaFolioPartida();
                        break;
                    case "SalidaPartida":
                        ImprimeSalidaPartida();
                        break;
                    case "SalidaFolioPartida":
                        ImprimeSalidaFolioPartida();
                        break;
                    case "EntradaFolio":
                        ImprimeEntradaFolio();
                        break;
                    case "SalidaFolio":
                        ImprimeSalidaFolio();
                        break;
                }
            }
            else
            {
                MessageBox.Show(@"La Fecha Final Debe Ser Mayor a Fecha Inicial, Verifique . .",
                               @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }

        private void ImprimeEntradaPartida()
        {
            var entradaDetalles = EntradaService.EntradaDetalleDao.RptEntradaPartida
                    (dtFechaIni.Value,dtFechaFin.Value,FrmAlmacen.AlmacenActual);

            if (entradaDetalles.Count != 0)
            {
                var lstEntradaPartida = new List<rptDataEntradaPartida>();
                foreach (var entradaDetalle in entradaDetalles)
                {
                    var entradaVale = new rptDataEntradaPartida()
                    {
                        Es = "ENTRADAS",
                        FechaIni = dtFechaIni.Value,
                        FechaFin = dtFechaFin.Value,
                        CvePartida = entradaDetalle[0].ToString(),
                        DesPartida = entradaDetalle[1].ToString(),
                        Presupuesto = Convert.ToDouble(entradaDetalle[2]),
                        TipoPresupuesto = entradaDetalle[3].ToString()
                    };
                    lstEntradaPartida.Add(entradaVale);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstEntradaPartida,
                    StrRptName = "rptEntradaPartida",
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

        private void ImprimeSalidaPartida()
        {
            var salidaDetalles = SalidaService.SalidaDetalleDao.RptSalidaPartida
                    (dtFechaIni.Value, dtFechaFin.Value, FrmAlmacen.AlmacenActual);

            if (salidaDetalles.Count != 0)
            {
                var lstSalidaPartida = new List<rptDataEntradaPartida>();
                foreach (var salidaDetalle in salidaDetalles)
                {
                    var entradaVale = new rptDataEntradaPartida()
                    {
                        Es = "SALIDAS",
                        FechaIni = dtFechaIni.Value,
                        FechaFin = dtFechaFin.Value,
                        CvePartida = salidaDetalle[0].ToString(),
                        DesPartida = salidaDetalle[1].ToString(),
                        Presupuesto = Convert.ToDouble(salidaDetalle[2]),
                        TipoPresupuesto = salidaDetalle[3].ToString()
                    };
                    lstSalidaPartida.Add(entradaVale);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstSalidaPartida,
                    StrRptName = "rptSalidaPartida",
                    StrTitle = "ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                };
                formaVisor.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"No Existen Salidas, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImprimeEntradaFolioPartida()
        {
            var entradaDetalles = EntradaService.EntradaDetalleDao.RptEntradaFolioPartida
                    (dtFechaIni.Value, dtFechaFin.Value, FrmAlmacen.AlmacenActual);

            if (entradaDetalles.Count != 0)
            {
                var lstEntrada = new List<rptDataEntradaFolioPartida>();
                foreach (var entradaDetalle in entradaDetalles)
                {
                    var entrada = new rptDataEntradaFolioPartida()
                    {
                        ES = "ENTRADAS",
                        FechaIni = dtFechaIni.Value,
                        FechaFin = dtFechaFin.Value,
                        NumPedido = (int)entradaDetalle[0],
                        TipoPedido = entradaDetalle[1].ToString(),
                        Factura = entradaDetalle[2].ToString(),
                        Fecha = DateTime.Parse(entradaDetalle[3].ToString()),
                        Folio = (int)entradaDetalle[4],
                        Desproveedor = entradaDetalle[5].ToString(),
                        Total = Convert.ToDouble(entradaDetalle[6]),
                        Partida = entradaDetalle[7].ToString()
                    };
                    lstEntrada.Add(entrada);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstEntrada,
                    StrRptName = "rptEntradaFolioPartida",
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

        private void ImprimeSalidaFolioPartida()
        {
            var salidaDetalles = SalidaService.SalidaDetalleDao.RptSalidaFolioPartida
                    (dtFechaIni.Value, dtFechaFin.Value, FrmAlmacen.AlmacenActual);

            if (salidaDetalles.Count != 0)
            {
                var lstSalida = new List<rptDataEntradaFolioPartida>();
                foreach (var salidaDetalle in salidaDetalles)
                {
                    var entrada = new rptDataEntradaFolioPartida()
                    {
                        ES = "SALIDAS",
                        FechaIni = dtFechaIni.Value,
                        FechaFin = dtFechaFin.Value,
                        Partida = salidaDetalle[0].ToString(),
                        Folio = (int)salidaDetalle[1],
                        Fecha = DateTime.Parse(salidaDetalle[2].ToString()),
                        Desproveedor = salidaDetalle[3].ToString(),
                        Total = Convert.ToDouble(salidaDetalle[4])
                    };
                    lstSalida.Add(entrada);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstSalida,
                    StrRptName = "rptSalidaFolioPartida",
                    StrTitle = "ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                };
                formaVisor.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"No Existen Salidas, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImprimeEntradaFolio()
        {
            var entradas = EntradaService.EntradaDao.RptEntradaFolio
                    (dtFechaIni.Value, dtFechaFin.Value, FrmAlmacen.AlmacenActual);

            if (entradas.Count != 0)
            {
                var lstEntrada = new List<rptDataEntradaFolio>();
                foreach (var entra in entradas)
                {
                    var entrada = new rptDataEntradaFolio()
                    {
                        ES = "ENTRADAS",
                        FechaIni = dtFechaIni.Value,
                        FechaFin = dtFechaFin.Value,
                        FolioEntrada = (int)entra[0],
                        Fecha = DateTime.Parse(entra[1].ToString()),
                        Proveedor = entra[2].ToString(),
                        Factura = entra[3].ToString(),
                        FolioPedido = (int)entra[4],
                        TipoPedido = entra[5].ToString(),
                        Total = Convert.ToDouble(entra[6]),
                    };
                    lstEntrada.Add(entrada);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstEntrada,
                    StrRptName = "rptEntradaFolio",
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

        private void ImprimeSalidaFolio()
        {
            var salidas = SalidaService.SalidaDetalleDao.RptSalidaFolio
                    (dtFechaIni.Value, dtFechaFin.Value, FrmAlmacen.AlmacenActual);

            if (salidas.Count != 0)
            {
                var lstSalida = new List<rptDataEntradaFolio>();
                foreach (var entra in salidas)
                {
                    var salida = new rptDataEntradaFolio()
                    {
                        ES = "SALIDAS",
                        FechaIni = dtFechaIni.Value,
                        FechaFin = dtFechaFin.Value,
                        FolioEntrada = (int)entra[0],
                        Fecha = DateTime.Parse(entra[1].ToString()),
                        Proveedor = entra[2].ToString(),
                        Total = Convert.ToDouble(entra[3]),
                    };
                    lstSalida.Add(salida);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstSalida,
                    StrRptName = "rptSalidaFolio",
                    StrTitle = "ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                };
                formaVisor.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"No Existen Salidas, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        

    }
}
