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
using Almacen.Business.ModRequisicion;
using Almacen.Data.RptsClass;
using Spring.Context;
using Spring.Context.Support;

namespace Almacen.View
{
    public partial class FrmSelectYearFolio : Form
    {
        #region Variables Miembro

        public string strOpcion; 
        private IEntradaService EntradaService;
        private ISalidaService SalidaService;
        private IRequisicionService RequisicionService;
        #endregion

        #region Contructores
        public FrmSelectYearFolio()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            EntradaService = ctx["entradaService"] as IEntradaService;
            SalidaService = ctx["salidaService"] as ISalidaService;
            RequisicionService = ctx["requisicionService"] as IRequisicionService;
            InicializarListas();
        }
        #endregion

        #region Eventos

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtFolio.Text, e);
        }

        private void txtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtFolio, e);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtFolio.TextLength>0 &&  int.Parse(txtFolio.Text) > 0 )
            {
                switch (strOpcion)
                {
                    case "EntradaVale":
                        ImprimeEntradaVale();
                        break;
                    case "SalidaVale":
                        ImprimeSalidaVale();
                        break;
                    case "RequisicionVale":
                        ImprimeRequisicionVale();
                        break;
                    case "PedidosGenerados":
                        ImprimePedidosGenerados();
                        break;
                }
            }
        }
        #endregion

        #region Metodos
        private void InicializarListas()
        {
            var dtActual = EntradaService.EntradaDao.FechaServidor();
            cmbAnioEntrada.Maximum = dtActual.Year;
            cmbAnioEntrada.Value = dtActual.Year;
            cmbAnioEntrada.Minimum = dtActual.Year - 1;
        }

        private void ImprimeEntradaVale()
        {
            var entrada = EntradaService.EntradaDao.CargaSoloEntrada(
                (int) cmbAnioEntrada.Value, FrmAlmacen.AlmacenActual.IdAlmacen, int.Parse(txtFolio.Text));
            
            if(entrada!=null)
            {
                if(entrada.Pedido!=null)
                {
                    var entregaDetalles = EntradaService.EntradaDetalleDao.RptEntradaVale
                    (int.Parse(txtFolio.Text), (int)cmbAnioEntrada.Value, FrmAlmacen.AlmacenActual.IdAlmacen);

                    if (entregaDetalles.Count !=0)
                    {
                        var lstEntradaVale = new List<rptDataEntradaVale>();
                        foreach (var entregaDetalle in entregaDetalles)
                        {
                            var entradaVale = new rptDataEntradaVale()
                                {
                                    Folio = (int) entregaDetalle[0],
                                    Fecha = DateTime.Parse(entregaDetalle[1].ToString()),
                                    Factura = entregaDetalle[2].ToString(),
                                    CveArt = (int)entregaDetalle[3],
                                    DesArt = entregaDetalle[4].ToString(),
                                    Unidad = entregaDetalle[5].ToString(),
                                    Recibida = Convert.ToDouble(entregaDetalle[6]),
                                    Lote = entregaDetalle[7]!=null?entregaDetalle[7].ToString():"",
                                    Caducidad = DateTime.Parse(entregaDetalle[8].ToString()),
                                    Proveedor = entregaDetalle[9].ToString(),
                                    Pedido = (int)entregaDetalle[10],
                                    TipoPedido = (int)entregaDetalle[11],
                                    Pedida = Convert.ToDouble(entregaDetalle[12]),
                                    PrecioUnitario =Convert.ToDouble(entregaDetalle[13]),
                                    Marca = entregaDetalle[14]!=null?entregaDetalle[14].ToString():"",
                                    Recibio = entregaDetalle[15].ToString(),
                                    Superviso = entregaDetalle[16].ToString(),
                                    Capturo = entregaDetalle[17].ToString(),
                                    Descuento = Convert.ToDouble(entregaDetalle[18]),
                                    Iva = int.Parse(entregaDetalle[19].ToString())
                                };
                            lstEntradaVale.Add(entradaVale);
                        }
                        var formaVisor = new FrmCrVisor
                            {
                                ObjList = lstEntradaVale,
                                StrRptName = "rptEntradaVale",
                                StrTitle = "ENTRADA AL ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                            };
                        formaVisor.ShowDialog();
                    }
                }
                else
                {
                    var entregaDetalles = EntradaService.EntradaDetalleDao.RptEntradaValeSinPedido
                    (int.Parse(txtFolio.Text), (int)cmbAnioEntrada.Value, FrmAlmacen.AlmacenActual.IdAlmacen);

                    if (entregaDetalles.Count != 0)
                    {
                        var lstEntradaVale = new List<rptDataEntradaVale>();
                        foreach (var entregaDetalle in entregaDetalles)
                        {
                            var entradaVale = new rptDataEntradaVale()
                            {
                                Folio = (int)entregaDetalle[0],
                                Fecha = DateTime.Parse(entregaDetalle[1].ToString()),
                                Factura = entregaDetalle[2].ToString(),
                                CveArt = (int)entregaDetalle[3],
                                DesArt = entregaDetalle[4].ToString(),
                                Unidad = entregaDetalle[5].ToString(),
                                Recibida = Convert.ToDouble(entregaDetalle[6]),
                                Lote = entregaDetalle[7] != null ? entregaDetalle[7].ToString() : "",
                                Caducidad = DateTime.Parse(entregaDetalle[8].ToString()),
                                //Proveedor = entregaDetalle[9].ToString(),
                                //Pedido = (int)entregaDetalle[10],
                                //TipoPedido = (int)entregaDetalle[11],
                                //Pedida = Convert.ToDouble(entregaDetalle[12]),
                                //PrecioUnitario = Convert.ToDouble(entregaDetalle[13]),
                                //Marca = entregaDetalle[14] != null ? entregaDetalle[14].ToString() : "",
                                Recibio = entregaDetalle[9].ToString(),
                                Superviso = entregaDetalle[10].ToString(),
                                Capturo = entregaDetalle[11].ToString(),
                                //Descuento = Convert.ToDouble(entregaDetalle[18]),
                                //Iva = int.Parse(entregaDetalle[19].ToString())
                                PrecioUnitario = Convert.ToDouble(entregaDetalle[12])
                            };
                            lstEntradaVale.Add(entradaVale);
                }
                        var formaVisor = new FrmCrVisor
                        {
                            ObjList = lstEntradaVale,
                            StrRptName = "rptEntradaVale",
                            StrTitle = "ENTRADA AL ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                        };
                        formaVisor.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show(@"La Entrada no Existe, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void ImprimeSalidaVale()
        {
            var salidaDetalles = SalidaService.SalidaDetalleDao.RptSalidaVale
                    (int.Parse(txtFolio.Text), (int)cmbAnioEntrada.Value, FrmAlmacen.AlmacenActual.IdAlmacen);

            if (salidaDetalles.Count != 0)
            {
                var lstSalidaVale = new List<rptDataSalidaVale>();
                foreach (var salidaDetalle in salidaDetalles)
                {
                    var salidaVale = new rptDataSalidaVale()
                    {
                        Area = FrmAlmacen.AlmacenActual.DesAlmacen,
                        Fecha = DateTime.Parse(salidaDetalle[0].ToString()),
                        Folio = (int)salidaDetalle[1],
                        CveArt = (int)salidaDetalle[2],
                        DesArticulo = salidaDetalle[3].ToString(),
                        Unidad = salidaDetalle[4].ToString(),
                        Cantidad = Convert.ToDouble(salidaDetalle[5]),
                        Costo = Convert.ToDouble(salidaDetalle[6]),
                        Caducidad = DateTime.Parse(salidaDetalle[7].ToString()),
                        Capturo = salidaDetalle[8].ToString(),
                        NumEntrada = (int)salidaDetalle[9]
                    };
                    lstSalidaVale.Add(salidaVale);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstSalidaVale,
                    StrRptName = "rptSalidaVale",
                    StrTitle = "SALIDA DE ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                };
                formaVisor.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"La Salida no Existe, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImprimeRequisicionVale()
        {
            var requisicionDetalles = RequisicionService.RequisicionDetallDao.RptRequisicionVale
                    (int.Parse(txtFolio.Text), (int)cmbAnioEntrada.Value, FrmAlmacen.AlmacenActual);

            if (requisicionDetalles.Count != 0)
            {
                var lstRequisicionVale = new List<rptDataRequisicionVale>();
                foreach (var requisicionDetalle in requisicionDetalles)
                {
                    var requisicionVale = new rptDataRequisicionVale()
                    {
                        Fecha = DateTime.Parse(requisicionDetalle[1].ToString()),
                        CveArt = (int)requisicionDetalle[2],
                        DesArticulo = requisicionDetalle[3].ToString(),
                        Unidad = requisicionDetalle[4].ToString(),
                        Cantidad = Convert.ToDouble(requisicionDetalle[5]),
                        Costo = Convert.ToDouble(requisicionDetalle[6]),
                        Licitacion = requisicionDetalle[7].ToString()
                    };
                    switch (requisicionDetalle[0].ToString().Length)
                    {
                        case 1 :
                            requisicionVale.NumeroRequisicion = 
                                int.Parse(DateTime.Parse(requisicionDetalle[1].ToString()).Year + "00" + 
                                        requisicionDetalle[0]);
                            break;
                        case 2: requisicionVale.NumeroRequisicion =
                                int.Parse(DateTime.Parse(requisicionDetalle[1].ToString()).Year + "0" +
                                        requisicionDetalle[0]);
                            break;
                        default: requisicionVale.NumeroRequisicion =
                                 int.Parse(DateTime.Parse(requisicionDetalle[1].ToString()).Year + 
                                         requisicionDetalle[0].ToString());
                            break;

                    }
                    lstRequisicionVale.Add(requisicionVale);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstRequisicionVale,
                    StrRptName = "rptRequisicionVale",
                    StrTitle = "REQUISICION DE ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                };
                formaVisor.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"La Requisicion no Existe, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImprimePedidosGenerados()
        {
            var pedidoDetalles = RequisicionService.PedidoDetalleDao.RptPedidosGenerados
                    (int.Parse(txtFolio.Text), (int)cmbAnioEntrada.Value, FrmAlmacen.AlmacenActual);

            if (pedidoDetalles.Count != 0)
            {
                var lstPedidosGenerados = new List<rptDataPedidosGenerados>();
                foreach (var pedidoDetalle in pedidoDetalles)
                {
                    var pedidoGenerado = new rptDataPedidosGenerados()
                    {
                        NumRequisicion = int.Parse(txtFolio.Text),
                        FechaRequisicion = DateTime.Parse(pedidoDetalle[0].ToString()),
                        NumPedido = (int)pedidoDetalle[1],
                        FechaPedido = DateTime.Parse(pedidoDetalle[2].ToString()),
                        Partida = pedidoDetalle[3].ToString(),
                        DesPartida = pedidoDetalle[4].ToString()
                    };
                    lstPedidosGenerados.Add(pedidoGenerado);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstPedidosGenerados,
                    StrRptName = "rptPedidosGenerados",
                    StrTitle = "REPORTE DE PEDIDOS GENERADOS ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                };
                formaVisor.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"La Requisicion no Existe, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        
        
    }
}
