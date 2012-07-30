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
    public partial class FrmSelectDayToDayCat : Form
    {
        #region Variables Miembro

        public string strOpcion;
        private IEntradaService EntradaService;
        //private ISalidaService SalidaService;
        private Proveedor ProveedorActual;
        #endregion

        #region Contructores
        public FrmSelectDayToDayCat()
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
                ProveedorActual = cmbProveedor.SelectedValue as Proveedor;
                if(ProveedorActual!=null)
                {
                    switch (strOpcion)
                    {
                        case "EntradaProveedor":
                            ImprimeEntradaProveedor();
                            break;
                        //case "SalidaPartida":
                        //    ImprimeSalidaPartida();
                        //    break;
                    }    
                }
                else
                {
                    MessageBox.Show(@"Seleccione Proveedor, Verifique . .",
                               @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show(@"La Fecha Final Debe Ser Mayor a Fecha Inicial, Verifique . .",
                               @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtProveedor.TextLength > 0 && int.Parse(txtProveedor.Text) > 0)
                    {
                        EntradaService.CargaProveedor(cmbProveedor, int.Parse(txtProveedor.Text));
                        if (cmbProveedor.Items.Count == 0)
                        {
                            MessageBox.Show(@"Clave de Proveedor No Existe, Verifique . .",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtProveedor, e);
        }

        private void cmbProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (cmbProveedor.Text.Length > 0)
                    {
                        EntradaService.CargaProveedores(cmbProveedor, '%' + cmbProveedor.Text.ToUpper() + '%');
                        if (cmbProveedor.Items.Count == 0)
                        {
                            MessageBox.Show(@"Clave de Proveedor No Existe, Verifique . .",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
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

            //lblDesPartida.Text = string.Empty;
        }

        

        private void ImprimeEntradaProveedor()
        {
            var entradaDetalles = EntradaService.EntradaDetalleDao.RptEntradaProveedor
                    (dtFechaIni.Value, dtFechaFin.Value, FrmAlmacen.AlmacenActual, ProveedorActual);

            if (entradaDetalles.Count != 0)
            {
                var lstEntradaProveedor = new List<rptDataEntradaProveedor>();
                foreach (var entradaDetalle in entradaDetalles)
                {
                    var entradaVale = new rptDataEntradaProveedor()
                    {
                        ES = "ENTRADAS",
                        FechaIni = dtFechaIni.Value,
                        FechaFin = dtFechaFin.Value,
                        intFolioPedido = (int)entradaDetalle[0],
                        strTipoPedido = entradaDetalle[1].ToString(),
                        intFolioEntrada = (int)entradaDetalle[2],
                        FechaEntrada = DateTime.Parse(entradaDetalle[3].ToString()),
                        CveArt = (int)entradaDetalle[4],
                        DesArticulo = entradaDetalle[5].ToString(),
                        Unidad = entradaDetalle[6].ToString(),
                        Cantidad = Convert.ToDouble(entradaDetalle[7]),
                        CostoUnit = Convert.ToDouble(entradaDetalle[8]),
                        Proveedor = ProveedorActual.CveProveedor + "  " +  ProveedorActual.NombreFiscal
                    };
                    lstEntradaProveedor.Add(entradaVale);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstEntradaProveedor,
                    StrRptName = "rptEntradaProveedor",
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
