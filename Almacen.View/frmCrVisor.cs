using System;
using System.Windows.Forms;
using Almacen.Data.Rpts.Inventario;
using Almacen.Data.Rpts.ModEntrada;
using Almacen.Data.Rpts.ModReportes;
using Almacen.Data.Rpts.ModSalida;
using Almacen.Data.Rpts.ModRequisicion;

namespace Almacen.View
{
    public partial class FrmCrVisor : Form
    {
        #region Variables Miembro
        public string StrRptName;
        public object ObjList;
        public string StrTitle;
        #endregion

        #region Constructores

        public FrmCrVisor()
        {
            InitializeComponent();
        }
        #endregion

        private void FrmCrVisor_Load(object sender, EventArgs e)
        {
            crVisor.ShowLogo = false;
            switch (StrRptName)
            {
                case "rptEntradaVale":
                    var cr01 = new rptEntradaVale();
                    cr01.SummaryInfo.ReportTitle = StrTitle;
                    cr01.SetDataSource(ObjList);
                    crVisor.ReportSource = cr01;
                    break;
                case "rptSalidaVale":
                    var cr02 = new rptSalidaVale();
                    cr02.SummaryInfo.ReportTitle = StrTitle;
                    cr02.SetDataSource(ObjList);
                    crVisor.ReportSource = cr02;
                    break;
                case "rptEntradaPartida":
                    var cr03 = new rptEntradaPartida();
                    cr03.SummaryInfo.ReportTitle = StrTitle;
                    cr03.SetDataSource(ObjList);
                    crVisor.ReportSource = cr03;
                    break;
                case "rptSalidaPartida":
                    var cr04 = new rptEntradaPartida();
                    cr04.SummaryInfo.ReportTitle = StrTitle;
                    cr04.SetDataSource(ObjList);
                    crVisor.ReportSource = cr04;
                    break;
                case "rptCierre":
                    var cr05 = new rptCierre();
                    cr05.SummaryInfo.ReportTitle = StrTitle;
                    cr05.SetDataSource(ObjList);
                    crVisor.ReportSource = cr05;
                    break;
                case "rptRequisicionVale":
                    var cr06 = new rptRequisicionVale();
                    cr06.SummaryInfo.ReportTitle = StrTitle;
                    cr06.SetDataSource(ObjList);
                    crVisor.ReportSource = cr06;
                    break;
                case "rptEntradaIFAI":
                    var cr07 = new rptEntradaIFAI();
                    cr07.SummaryInfo.ReportTitle = StrTitle;
                    cr07.SetDataSource(ObjList);
                    crVisor.ReportSource = cr07;
                    break;
                case "rptKardex":
                    var cr08 = new rptKardex();
                    cr08.SummaryInfo.ReportTitle = StrTitle;
                    cr08.SetDataSource(ObjList);
                    crVisor.ShowGroupTreeButton = true;
                    crVisor.ReportSource = cr08;
                    break;
                case "rptPedidosGenerados":
                    var cr09 = new rptPedidosGenerados();
                    cr09.SummaryInfo.ReportTitle = StrTitle;
                    cr09.SetDataSource(ObjList);
                    crVisor.ReportSource = cr09;
                    break;
                case "rptEntradaFolioPartida":
                    var cr10 = new rptEntradaFolioPartida();
                    cr10.SummaryInfo.ReportTitle = StrTitle;
                    cr10.SetDataSource(ObjList);
                    crVisor.ReportSource = cr10;
                    break;
                case "rptSalidaFolioPartida":
                    var cr11 = new rptSalidaFolioPartida();
                    cr11.SummaryInfo.ReportTitle = StrTitle;
                    cr11.SetDataSource(ObjList);
                    crVisor.ReportSource = cr11;
                    break;
                case "rptEntradaDetallado":
                    var cr12 = new rptEntradaDetallado();
                    cr12.SummaryInfo.ReportTitle = StrTitle;
                    cr12.SetDataSource(ObjList);
                    crVisor.ReportSource = cr12;
                    break;
                case "rptSalidaDetallado":
                    var cr13 = new rptSalidaDetallado();
                    cr13.SummaryInfo.ReportTitle = StrTitle;
                    cr13.SetDataSource(ObjList);
                    crVisor.ReportSource = cr13;
                    break;
                case "rptEntradaProveedor":
                    var cr14 = new rptEntradaProveedor();
                    cr14.SummaryInfo.ReportTitle = StrTitle;
                    cr14.SetDataSource(ObjList);
                    crVisor.ReportSource = cr14;
                    break;
                case "rptEntradaFolio":
                    var cr15 = new rptEntradaFolio();
                    cr15.SummaryInfo.ReportTitle = StrTitle;
                    cr15.SetDataSource(ObjList);
                    crVisor.ReportSource = cr15;
                    break;
                case "rptSalidaFolio":
                    var cr16 = new rptSalidaFolio();
                    cr16.SummaryInfo.ReportTitle = StrTitle;
                    cr16.SetDataSource(ObjList);
                    crVisor.ReportSource = cr16;
                    break;
                case "rptEntradaPedido":
                    var cr17 = new rptEntradaPedido();
                    cr17.SummaryInfo.ReportTitle = StrTitle;
                    cr17.SetDataSource(ObjList);
                    crVisor.ReportSource = cr17;
                    break;
                case "rptSalidaArea":
                    var cr18 = new rptSalidaArea();
                    cr18.SummaryInfo.ReportTitle = StrTitle;
                    cr18.SetDataSource(ObjList);
                    crVisor.ReportSource = cr18;
                    break;
            }
            crVisor.Zoom(1);
            crVisor.Refresh();
            
        }

        #region Eventos
        
        #endregion

        #region Metodos
        
        #endregion

        

        

        

      

        

        

       

       

       

        

        

        

       

        

    }
}
