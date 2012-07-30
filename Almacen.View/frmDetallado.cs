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
    public partial class FrmDetallado : Form
    {
        #region Variables Miembro

        public string strOpcion;
        private IEntradaService EntradaService;
        private ISalidaService SalidaService;
        
        #endregion

        #region Contructores
        public FrmDetallado()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            EntradaService = ctx["entradaService"] as IEntradaService;
            SalidaService = ctx["salidaService"] as ISalidaService;
            InicializarListas();
        }
        #endregion

        #region Eventos

        private void txtEntradaIni_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtEntradaIni,e);
        }

        private void txtEntradaIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtEntradaIni,e);
        }

        private void txtEntradaFin_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtEntradaFin,e);
        }
        private void txtEntradaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtEntradaFin,e);
        }

        private void txtPedidoIni_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtPedidoIni, e);
        }

        private void txtPedidoIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtPedidoIni, e);
        }

        private void txtPedidoFin_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtPedidoFin, e);
        }

        private void txtPedidoFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtPedidoFin, e);
        }

        private void txtCveArea_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtCveArea.TextLength > 0 && int.Parse(txtCveArea.Text) > 0)
                    {
                        SalidaService.CargaArea(cmbArea, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
                                                           int.Parse(txtCveArea.Text));
                        if (cmbArea.Items.Count == 0)
                        {
                            MessageBox.Show(@"Clave de Area No Existe , Verifique . .",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private void txtCveArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtCveArea, e);
        }

        private void cmbArea_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (cmbArea.Text.Length > 0)
                    {
                        SalidaService.CargaAreas(cmbArea, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
                                                           '%' + cmbArea.Text.ToUpper() + '%');
                        if (cmbArea.Items.Count == 0)
                        {
                            MessageBox.Show(@"El Area No Existe , Verifique . .",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private void FrmDetallado_Load(object sender, EventArgs e)
        {
            switch (strOpcion)
            {
                case "EntradaDetallado":
                    chkArea.Visible = false;
                    lblArea.Visible = false;
                    cmbArea.Visible = false;
                    break;
                case "SalidaDetallado":
                    label2.Text = @"Fecha de Salida";
                    label3.Text = @"Folio de Salida";

                    chkPedidoTipo.Visible = false;
                    chkPedidoFecha.Visible = false;
                    chkPedidoFolio.Visible = false;
                    lblPedidoTipo.Visible = false;
                    lblPedidoFecha.Visible = false;
                    lblPedidoFolio.Visible = false;

                    cmbTipoPedido.Visible = false;

                    dtFechaPedidoIni.Visible = false;
                    dtFechaPedidoFin.Visible = false;

                    txtPedidoIni.Visible = false;
                    txtPedidoFin.Visible = false;

                    label10.Visible = false;
                    label11.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;

                    break;

            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var blnFlag = false;
            var strEntradaFecha = "";
            var strEntradaFolio = "";
            var strSituacion = "";
            var strTipoPedido = "";
            var strPedidoFecha = "";
            var strPedidoFolio = "";

            var strSalidaFecha = "";
            var strSalidaFolio = "";
            var strCatArea = "";

            switch (strOpcion)
            {
                case "EntradaDetallado":

                    #region Filtros
                    if (chkEntradaFecha.Checked)
                    {
                        if (dtFechaFin.Value >= dtFechaIni.Value)
                        {
                            strEntradaFecha = "ed.Entrada.FechaEntrada between '" +
                                              dtFechaIni.Value.Month + "-" +
                                              dtFechaIni.Value.Day + "-" +
                                              dtFechaIni.Value.Year + "' and '" +
                                              dtFechaFin.Value.Month + "-" +
                                              dtFechaFin.Value.Day + "-" +
                                              dtFechaFin.Value.Year + "' and ";
                            blnFlag = true;
                        }
                        else
                        {
                            MessageBox.Show(@"La Fecha Final Debe Ser Mayor a Fecha Inicial, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dtFechaIni.Focus();
                            return;
                        }
                    }

                    if (chkEntradaFolio.Checked)
                    {
                        if (txtEntradaIni.TextLength > 0 && txtEntradaFin.TextLength > 0 &&
                            (Int64.Parse(txtEntradaFin.Text) >= Int64.Parse(txtEntradaIni.Text)))
                        {
                            strEntradaFolio = "ed.Entrada.NumeroEntrada between " +
                                              Int64.Parse(txtEntradaIni.Text) + " and " +
                                              Int64.Parse(txtEntradaFin.Text) + " and ";
                            blnFlag = true;
                        }
                        else
                        {
                            MessageBox.Show(@"Folio Final Debe Ser Mayor a Folio Inicial, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEntradaIni.Focus();
                            return;
                        }

                    }

                    if (chkSituacion.Checked)
                    {
                        switch (cmbSituacion.SelectedValue.ToString())
                        {
                            case "A":
                                strSituacion = "(ed.Entrada.EstadoEntrada <> 'C' or ed.Entrada.EstadoEntrada is null) and ";
                                break;
                            case "C":
                                strSituacion = "ed.Entrada.EstadoEntrada = 'C' and ";
                                break;
                            case "T":
                                strSituacion = "";
                                break;
                        }
                        blnFlag = true;
                    }

                    if (chkPedidoTipo.Checked)
                    {
                        strTipoPedido = "ed.Entrada.Pedido.CatTipopedido = :objCatTipopedido and ";
                        blnFlag = true;
                    }

                    if (chkPedidoFecha.Checked)
                    {
                        if (dtFechaPedidoFin.Value >= dtFechaPedidoIni.Value)
                        {
                            strPedidoFecha = "ed.Entrada.Pedido.FechaPedido between '" +
                                             dtFechaPedidoIni.Value.Month + "-" +
                                             dtFechaPedidoIni.Value.Day + "-" +
                                             dtFechaPedidoIni.Value.Year + "' and '" +
                                             dtFechaPedidoFin.Value.Month + "-" +
                                             dtFechaPedidoFin.Value.Day + "-" +
                                             dtFechaPedidoFin.Value.Year + "' and ";
                            blnFlag = true;
                        }
                        else
                        {
                            MessageBox.Show(@"La Fecha Final Debe Ser Mayor a Fecha Inicial, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dtFechaPedidoIni.Focus();
                            return;
                        }
                    }

                    if (chkPedidoFolio.Checked)
                    {
                        if (txtPedidoIni.TextLength > 0 && txtPedidoFin.TextLength > 0 &&
                            (Int64.Parse(txtPedidoFin.Text) >= Int64.Parse(txtPedidoIni.Text)))
                        {
                            strPedidoFolio = "ed.Entrada.Pedido.NumeroPedido between " +
                                             Int64.Parse(txtPedidoIni.Text) + " and " +
                                             Int64.Parse(txtPedidoFin.Text) + " and ";
                            blnFlag = true;
                        }
                        else
                        {
                            MessageBox.Show(@"Folio Final Debe Ser Mayor a Folio Inicial, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPedidoIni.Focus();
                            return;
                        }
                    }
                    #endregion


                    if (blnFlag)
                    {
                        ImprimeEntradaDetallado(strEntradaFecha, strEntradaFolio, strSituacion, strTipoPedido,
                                                cmbTipoPedido.SelectedValue as CatTipopedido, strPedidoFecha,
                                                strPedidoFolio);
                    }
                    else
                    {
                        MessageBox.Show(@"Seleccionar Filtro de Busqueda, Verifique . .",
                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "SalidaDetallado":

                    #region Filtros
                    if (chkEntradaFecha.Checked)
                    {
                        if (dtFechaFin.Value >= dtFechaIni.Value)
                        {
                            strSalidaFecha = "sd.Salida.FechaSalida between '" +
                                              dtFechaIni.Value.Month + "-" +
                                              dtFechaIni.Value.Day + "-" +
                                              dtFechaIni.Value.Year + "' and '" +
                                              dtFechaFin.Value.Month + "-" +
                                              dtFechaFin.Value.Day + "-" +
                                              dtFechaFin.Value.Year + "' and ";
                            blnFlag = true;
                        }
                        else
                        {
                            MessageBox.Show(@"La Fecha Final Debe Ser Mayor a Fecha Inicial, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dtFechaIni.Focus();
                            return;
                        }
                    }

                    if (chkEntradaFolio.Checked)
                    {
                        if (txtEntradaIni.TextLength > 0 && txtEntradaFin.TextLength > 0 &&
                            (Int64.Parse(txtEntradaFin.Text) >= Int64.Parse(txtEntradaIni.Text)))
                        {
                            strSalidaFolio = "sd.Salida.NumeroSalida between " +
                                              Int64.Parse(txtEntradaIni.Text) + " and " +
                                              Int64.Parse(txtEntradaFin.Text) + " and ";
                            blnFlag = true;
                        }
                        else
                        {
                            MessageBox.Show(@"Folio Final Debe Ser Mayor a Folio Inicial, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEntradaIni.Focus();
                            return;
                        }

                    }

                    if (chkSituacion.Checked)
                    {
                        switch (cmbSituacion.SelectedValue.ToString())
                        {
                            case "A":
                                strSituacion = "(sd.Salida.EstadoSalida <> 'C' or sd.Salida.EstadoSalida is null) and ";
                                break;
                            case "C":
                                strSituacion = "sd.Salida.EstadoSalida = 'C' and ";
                                break;
                            case "T":
                                strSituacion = "";
                                break;
                        }
                        blnFlag = true;
                    }

                    if (chkArea.Checked)
                    {
                        var objCatArea = cmbArea.SelectedValue as CatArea;
                        if(objCatArea!=null)
                        {
                            strCatArea = "sd.Salida.CatArea = :objCatArea and ";
                            blnFlag = true;
                        }
                        else
                        {
                            MessageBox.Show(@"Seleccionar Area de Busqueda, Verifique . .",
                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCveArea.Focus();
                        }
                    }

                    #endregion

                    
                    if (blnFlag)
                    {
                        ImprimeSalidaDetallado(strSalidaFecha, strSalidaFolio, strSituacion,
                                                strCatArea, cmbArea.SelectedValue as CatArea);
                    }
                    else
                    {
                        MessageBox.Show(@"Seleccionar Filtro de Busqueda, Verifique . .",
                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            dtFechaPedidoIni.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFechaPedidoIni.Value = dtActual;
            dtFechaPedidoIni.MinDate = new DateTime(dtActual.Year - 1, 1, 1);

            dtFechaPedidoFin.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFechaPedidoFin.Value = dtActual;
            dtFechaPedidoFin.MinDate = new DateTime(dtActual.Year - 1, 1, 1);

            EntradaService.CatTipoPedidos(cmbTipoPedido);
            EntradaService.SituacionCombo(cmbSituacion);
        }


        private void ImprimeEntradaDetallado(string strEntradaFecha, string strEntradaFolio, string strSituacion,
                        string strTipoPedido, CatTipopedido objCatTipopedido, string strPedidoFecha, string strPedidoFolio)
        {
            var entradaDetalles = EntradaService.EntradaDetalleDao.RptEntradaDetallado
                    (FrmAlmacen.AlmacenActual, strEntradaFecha, strEntradaFolio, strSituacion, strTipoPedido, objCatTipopedido,
                    strPedidoFecha, strPedidoFolio);

            if (entradaDetalles.Count != 0)
            {
                var lstEntrada = new List<rptDataEntradaDetallado>();
                foreach (var entradaDetalle in entradaDetalles)
                {
                    var entrada = new rptDataEntradaDetallado()
                    {
                        Es = "ENTRADAS",
                        Fecha = DateTime.Parse(entradaDetalle[0].ToString()),
                        Folio = (int)entradaDetalle[1],
                        Factura = entradaDetalle[2].ToString(),
                        TipoPedido = entradaDetalle[3].ToString(),
                        FechaPedido = DateTime.Parse(entradaDetalle[4].ToString()),
                        NumPedido = (int)entradaDetalle[5],
                        CveArt = (int)entradaDetalle[6],
                        DesArticulo = entradaDetalle[7].ToString(),
                        Cantidad = (decimal)entradaDetalle[8],
                        Marca = entradaDetalle[9]==null?"":entradaDetalle[9].ToString(),
                        Precio = (decimal)entradaDetalle[10],
                        Caducidad = DateTime.Parse(entradaDetalle[11].ToString()),
                        Lote = entradaDetalle[12].ToString(),
                        Descuento = (decimal)entradaDetalle[13],
                        Iva = Convert.ToInt16(entradaDetalle[14]),
                        Status = entradaDetalle[15] == null ? "A" : entradaDetalle[15].ToString()
                    };
                    lstEntrada.Add(entrada);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstEntrada,
                    StrRptName = "rptEntradaDetallado",
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

        private void ImprimeSalidaDetallado(string strEntradaFecha, string strEntradaFolio, string strSituacion,
                        string strCatArea, CatArea objCatArea)
        {
            var salidaDetalles = SalidaService.SalidaDetalleDao.RptSalidaDetallado
                    (FrmAlmacen.AlmacenActual, strEntradaFecha, strEntradaFolio, strSituacion, strCatArea, objCatArea);

            if (salidaDetalles.Count != 0)
            {
                var lstSalida = new List<rptDataEntradaDetallado>();
                foreach (var salidaDetalle in salidaDetalles)
                {
                    var entrada = new rptDataEntradaDetallado()
                    {
                        Es = "SALIDAS",
                        Fecha = DateTime.Parse(salidaDetalle[0].ToString()),
                        Folio = (int)salidaDetalle[1],
                        Factura = salidaDetalle[2].ToString(),
                        
                        CveArt = (int)salidaDetalle[3],
                        DesArticulo = salidaDetalle[4].ToString(),

                        Cantidad = (decimal)salidaDetalle[5],
                        Precio = (decimal)salidaDetalle[6],

                        Caducidad = DateTime.Parse(salidaDetalle[7].ToString()),
                        Lote = salidaDetalle[8] + "-" + salidaDetalle[9],
                        
                        Status = salidaDetalle[10] == null ? "A" : salidaDetalle[10].ToString()
                    };
                    lstSalida.Add(entrada);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstSalida,
                    StrRptName = "rptSalidaDetallado",
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
