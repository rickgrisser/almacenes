using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Almacen.Data.Entities;

namespace Almacen.View
{
    public partial class FrmMenu : Form
    {
        private int childFormNumber = 0;
        private bool bolFlag=false;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            this.Text = "ALMACEN " + FrmAlmacen.AlmacenActual.DesAlmacen + " - Menú Principal";
            lb_texto.Text = "BIENVENIDO: " + FrmAcceso.UsuarioLog.Nombre;

            if(FrmAlmacen.AlmacenActual.IdAlmacen.Contains("F"))
            {
                mnuCatModCuadro.Visible = true;
                mnuEntRptIfai.Visible = true;
                mnuRptPedidosGenerados.Visible = true;
            }

            if (FrmAlmacen.AlmacenActual.IdAlmacen.Contains("S"))
            {
                mnuEntAfectacionesSP.Visible = true;
                mnuEntImpresion.Visible = false;
                mnuEntRpt.Visible = false;
                mnuSalidas.Visible = false;
                mnuInventarios.Visible = false;
                mnuRequisicion.Visible = false;
                mnuReportes.Visible = false;
                mnuCatModificar.Visible = false;
            }

            if(FrmAlmacen.AlmacenActual.IdAlmacen.Contains("A"))
            {
                mnuEntAfectacionesSP.Visible = true;
            }
        }

        private void frm_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(bolFlag==false)
            {Application.Exit();}
            
        }

        private void afectacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var formaEntrada = new FrmEntrada();
            formaEntrada.ShowDialog();
        }

        private void mnuEntAfectacionesSP_Click(object sender, EventArgs e)
        {
            var formaEntrada = new FrmEntradaSP();
            formaEntrada.ShowDialog();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            bolFlag = false;
            Application.Exit();
        }

        private void rep_ent_partida_Click(object sender, EventArgs e)
        {
            var formaEntradaVale = new FrmSelectDayToDay
                {
                    strOpcion = "EntradaPartida", 
                    Text = @"Impresion Entradas por Partida"
                };
            formaEntradaVale.ShowDialog();
        }

        private void imp_entrada_Click(object sender, EventArgs e)
        {
            var formaEntradaVale = new FrmSelectYearFolio()
                {
                    strOpcion = "EntradaVale", 
                    Text = @"Impresion Vale Entrada"
                };
            formaEntradaVale.ShowDialog();
        }

        private void mod_factura_Click(object sender, EventArgs e)
        {
            //frm_ModificaFactura formaModificaFactura = new frm_ModificaFactura();
            //formaModificaFactura.ShowDialog();

        }

        private void imp_salida_Click(object sender, EventArgs e)
        {
            var formaEntradaVale = new FrmSelectYearFolio()
                {
                    strOpcion = "SalidaVale", 
                    Text = @"Impresion Vale Salida"
                };
            formaEntradaVale.ShowDialog();
        }

        private void rep_sal_partida_Click(object sender, EventArgs e)
        {
            var formaEntradaVale = new FrmSelectDayToDay
            {
                strOpcion = "SalidaPartida",
                Text = @"Impresion Salidas por Partida"
            };
            formaEntradaVale.ShowDialog();
        }

        private void afec_salidas_Click(object sender, EventArgs e)
        {

            var formaSalida = new FrmSalida();
            formaSalida.ShowDialog();
        }

        private void rep_ent_folio_Click(object sender, EventArgs e)
        {
            var formaEntradaFolio = new FrmSelectDayToDay
            {
                strOpcion = "EntradaFolio",
                Text = @"Impresion de Entradas por Folio"
            };
            formaEntradaFolio.ShowDialog();
        }

        private void rep_ent_fol_partida_Click(object sender, EventArgs e)
        {
           
            var formaEntradaVale = new FrmSelectDayToDay
            {
                strOpcion = "EntradaFolioPartida",
                Text = @"Impresion de Entradas por Folio y Partida"
            };
            formaEntradaVale.ShowDialog();
        }

        private void rep_ent_pedido_Click(object sender, EventArgs e)
        {
            var formaEntradaPedido = new FrmSelectYearFolioCat()
            {
                strOpcion = "EntradaPedido",
                Text = @"Impresion de Entradas por Pedido"
            };
            formaEntradaPedido.ShowDialog();
        }

        private void rep_ent_proveedor_Click(object sender, EventArgs e)
        {
            var formaEntradaProveedor = new FrmSelectDayToDayCat()
            {
                strOpcion = "EntradaProveedor",
                Text = @"Impresion de Entradas por Proveedor"
            };
            formaEntradaProveedor.ShowDialog();
        }

        private void rep_ent_detallado_Click(object sender, EventArgs e)
        {
            var formaEntradaDetallado = new FrmDetallado()
            {
                strOpcion = "EntradaDetallado",
                Text = @"Impresion Detallado de Entradas"
            };
            formaEntradaDetallado.ShowDialog();
        }

        private void rep_sal_folio_Click(object sender, EventArgs e)
        {
            var formaSalidaFolio = new FrmSelectDayToDay()
            {
                strOpcion = "SalidaFolio",
                Text = @"Impresion de Salida por Folio"
            };
            formaSalidaFolio.ShowDialog();
        }

        private void rep_sal_fol_partida_Click(object sender, EventArgs e)
        {
            var formaEntradaVale = new FrmSelectDayToDay
            {
                strOpcion = "SalidaFolioPartida",
                Text = @"Impresion de Salidas por Folio y Partida"
            };
            formaEntradaVale.ShowDialog();
        }

        private void rep_sal_area_Click(object sender, EventArgs e)
        {
            var formaSalidaArea = new FrmSelectDayToDay2Cat
            {
                strOpcion = "SalidaArea",
                Text = @"Impresion de Salidas por Area"
            };
            formaSalidaArea.ShowDialog();
        }

        private void rep_sal_area_costo_Click(object sender, EventArgs e)
        {
            //frm_RepSalArea formaRepSalAreaCosto = new frm_RepSalArea();
            //formaRepSalAreaCosto.Text = "Reporte de Salidas por Area y Costo";
            //formaRepSalAreaCosto.ShowDialog();
        }

        private void rep_sal_prop_area_Click(object sender, EventArgs e)
        {
            //frm_RepArtPropArea formaRepArtPropArea = new frm_RepArtPropArea();
            //formaRepArtPropArea.ShowDialog();
        }

        private void rep_sal_prop_concentrado_Click(object sender, EventArgs e)
        {
            //frm_RepArtProp formaRepArtProp = new frm_RepArtProp();
            //formaRepArtProp.ShowDialog();
        }

        private void rep_sal_detallado_Click(object sender, EventArgs e)
        {
            var formaEntradaDetallado = new FrmDetallado()
            {
                strOpcion = "SalidaDetallado",
                Text = @"Impresion Detallado de Salidas"
            };
            formaEntradaDetallado.ShowDialog();
        }

        private void gen_cierre_Click(object sender, EventArgs e)
        {
            var formaInventario = new FrmInvenCierreGenerar();
            formaInventario.ShowDialog();
        }

        private void imp_cierre_Click(object sender, EventArgs e)
        {
            var formaInventario = new FrmInvenCierreImp();
            formaInventario.ShowDialog();
        }

        private void borrarCierreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formaInventario = new FrmInvenCierreBorrar();
            formaInventario.ShowDialog();
        }

        private void asignaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Conteos formaAsignaMarbete = new frm_Conteos();
            //formaAsignaMarbete.Text = "Asignación de Marbetes";
            //formaAsignaMarbete.ShowDialog();
        }

        private void impresiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_ImprimeMarbete formaImprimeMarbete = new frm_ImprimeMarbete();
            //formaImprimeMarbete.ShowDialog();
        }

        private void erConteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Conteos formaConteos = new frm_Conteos();
            //formaConteos.Text = "Primer Conteo";
            //formaConteos.ShowDialog();
        }

        private void doConteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Conteos formaConteos = new frm_Conteos();
            //formaConteos.Text = "Segundo Conteo";
            //formaConteos.ShowDialog();
        }

        private void difConteosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_ImprimeCierre formaDifConteos = new frm_ImprimeCierre();
            //formaDifConteos.Text = "Reporte de Diferencia de Conteos";
            //formaDifConteos.ShowDialog();
        }

        private void difKardexInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_ImprimeCierre formaDifKardexInventario = new frm_ImprimeCierre();
            //formaDifKardexInventario.Text = "Reporte de Diferencia de Kardex-Inventario";
            //formaDifKardexInventario.ShowDialog();
        }

        private void impInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_ImprimeCierre formaImpInventario = new frm_ImprimeCierre();
            //formaImpInventario.Text = "Impresión del Inventario";
            //formaImpInventario.ShowDialog();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_AltaInventario formaAltaInventario = new frm_AltaInventario();
            //formaAltaInventario.ShowDialog();
        }

        private void rep_existencias_Click(object sender, EventArgs e)
        {
            //frm_RepExistencia formaRepExistencia = new frm_RepExistencia();
            //formaRepExistencia.ShowDialog();
        }

        private void rep_kardex_Click(object sender, EventArgs e)
        {
            var formaKardex = new FrmKardex()
                {
                    strOpcion = "Kardex",
                    Text = @"Impresión de Kardex"
                };
            formaKardex.ShowDialog();
        }

        private void rep_caducidades_Click(object sender, EventArgs e)
        {
            //frm_RepCaducidaes formaRepCaducidades = new frm_RepCaducidaes();
            //formaRepCaducidades.ShowDialog();
        }

        private void cat_articulo_Click(object sender, EventArgs e)
        {
            var formaCatArticulo = new FrmCatalogoArticulo();
            formaCatArticulo.ShowDialog();
        }

        private void rep_saldos_Click(object sender, EventArgs e)
        {
            //frm_RepSaldos formaRepSaldos = new frm_RepSaldos();
            //formaRepSaldos.ShowDialog();
        }

        private void rep_lento_Click(object sender, EventArgs e)
        {
            //frm_RepMovmiento formaLentoMovimiento = new frm_RepMovmiento();
            //formaLentoMovimiento.Text = "Reporte de Lento Movimiento de Insumos";
            //formaLentoMovimiento.ShowDialog();
        }

        private void rep_nulo_Click(object sender, EventArgs e)
        {
            //frm_RepMovmiento formaNuloMovimiento = new frm_RepMovmiento();
            //formaNuloMovimiento.Text = "Reporte de Nulo Movimiento de Insumos";
            //formaNuloMovimiento.ShowDialog();
        }

        private void afectacionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formaRequisicion = new FrmRequisicion();
            formaRequisicion.ShowDialog();
        }

        private void impresiónToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formaEntradaVale = new FrmSelectYearFolio()
            {
                strOpcion = "RequisicionVale",
                Text = @"Impresión Vale Requisición"
            };
            formaEntradaVale.ShowDialog();
        }

        private void costeadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Impresion formaImpresionRequisicionCosteada = new frm_Impresion();
            //formaImpresionRequisicionCosteada.Text = "Impresión de Requisición Costeada";
            //formaImpresionRequisicionCosteada.ShowDialog();
        }

        private void porSolicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_RepReqSolicitar formaRepReqxSolicitar = new frm_RepReqSolicitar();
            //formaRepReqxSolicitar.Text = "Reporte de Insumos por Solicitar";
            //formaRepReqxSolicitar.ShowDialog();
        }

        private void cuadroLicitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_RepReqSolicitar formaRepCuadroLicitacion = new frm_RepReqSolicitar();
            //formaRepCuadroLicitacion.Text = "Reporte de Cuadro de Licitación";
            //formaRepCuadroLicitacion.ShowDialog();
        }

        private void cat_area_Click(object sender, EventArgs e)
        {
            //frm_CatalogoAreas formaCatArea = new frm_CatalogoAreas();
            //formaCatArea.ShowDialog();
        }

        private void minutaResguardoEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_Resguardo_Entrega formaResguardoEntrega = new frm_Resguardo_Entrega();
            //formaResguardoEntrega.ShowDialog();
        }

        private void partidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formaEntrada = new FrmCatArticuloCambiar();
            formaEntrada.BlnOption = false;
            formaEntrada.ShowDialog();
        }

        private void cuadroBasicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formaEntrada = new FrmCatArticuloCambiar();
            formaEntrada.BlnOption = true;
            formaEntrada.ShowDialog();
        }

        private void mnuCambiar_Click(object sender, EventArgs e)
        {
            bolFlag = true;
            Close();
        }

        private void mnuEntRptIfai_Click(object sender, EventArgs e)
        {
            var formaEntradaVale = new FrmSelectDayToDayPart()
            {
                strOpcion = "EntradaIFAI",
                Text = @"Impresión Reporte IFAI"
            };
            formaEntradaVale.ShowDialog();
        }

        private void mnuRptPedidosGenerados_Click(object sender, EventArgs e)
        {
            var formaImpPedidos = new FrmSelectYearFolio()
            {
                strOpcion = "PedidosGenerados",
                Text = @"Impresión de Pedidos Generados por Requisición"
            };
            formaImpPedidos.ShowDialog();
        }

    }
}
