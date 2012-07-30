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
using Almacen.Data.Entities;
using Almacen.Data.RptsClass;
using Spring.Context;
using Spring.Context.Support;

namespace Almacen.View
{
    public partial class FrmSelectYearFolioCat : Form
    {
        #region Variables Miembro

        public string strOpcion; 
        private IEntradaService EntradaService;
        
        #endregion

        #region Contructores
        public FrmSelectYearFolioCat()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            EntradaService = ctx["entradaService"] as IEntradaService;
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
                    case "EntradaPedido":
                        ImprimeEntradaPedido();
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

            EntradaService.CatTipoPedidos(cmbTipoPedido);
        }

        private void ImprimeEntradaPedido()
        {
            var entradaDetalles = EntradaService.EntradaDetalleDao.RptEntradaPedido
                    (FrmAlmacen.AlmacenActual, int.Parse(txtFolio.Text), (int)cmbAnioEntrada.Value,
                    cmbTipoPedido.SelectedValue as CatTipopedido);

            if (entradaDetalles.Count != 0)
            {
                var lstEntradas = new List<rptDataEntradaPedido>();
                foreach (var entradadetalle in entradaDetalles)
                {
                    var objArticuloId = new ArticuloId((int) entradadetalle[10], FrmAlmacen.AlmacenActual);
                    var objArticulo = EntradaService.ArticuloDao.Get(objArticuloId);
                    
                    var entrada = new rptDataEntradaPedido()
                    {
                        InfoPedido = entradadetalle[0] + " " + entradadetalle[1] + " " + 
                                    Convert.ToDateTime(entradadetalle[2]).ToShortDateString(),
                        Proveedor = entradadetalle[3].ToString(),
                        CveArt = objArticulo.Id.CveArt,
                        DesArticulo = objArticulo.DesArticulo,
                        Unidad = objArticulo.CatUnidad,
                        FechaEntrada = Convert.ToDateTime(entradadetalle[4].ToString()),
                        FolioEntrada = (int)entradadetalle[5],
                        Factura = entradadetalle[6].ToString(),
                        CantidadPedida = Convert.ToDouble(entradadetalle[7]),
                        CantidadRecibida = Convert.ToDouble(entradadetalle[8]),
                        CostoUnitario = Convert.ToDouble(entradadetalle[9]),
                        CantidadxRecibir = Convert.ToDouble(entradadetalle[11])
                    };
                    lstEntradas.Add(entrada);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstEntradas,
                    StrRptName = "rptEntradaPedido",
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
