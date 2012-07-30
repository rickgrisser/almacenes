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
    public partial class FrmSelectDayToDay2Cat : Form
    {
        #region Variables Miembro

        public string strOpcion;
        //private IEntradaService EntradaService;
        private ISalidaService SalidaService;
        private CatPartida CatPartidaActual;
        private CatArea CatAreaActual;
        #endregion

        #region Contructores
        public FrmSelectDayToDay2Cat()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            //EntradaService = ctx["entradaService"] as IEntradaService;
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
                    case "SalidaArea":
                            if(CatPartidaActual!=null)
                            {
                                CatAreaActual = cmbProveedor.SelectedValue as CatArea;
                                ImprimeEntradaProveedor(CatAreaActual != null
                                                            ? "sd.Salida.CatArea = :objCatArea and "
                                                            : "");
                            }
                            else
                            {
                                MessageBox.Show(@"Ingrese Partida, Verifique . .",
                                           @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        break;
                    
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
                        switch (strOpcion)
                        {
                            case "SalidaArea":
                                SalidaService.CargaArea(cmbProveedor, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
                                                    int.Parse(txtProveedor.Text));
                                if (cmbProveedor.Items.Count == 0)
                                {
                                    cmbProveedor.Text = string.Empty;
                                    MessageBox.Show(@"Clave de Area No Existe, Verifique . .",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
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
                        switch (strOpcion)
                        {
                            case "SalidaArea":
                                    SalidaService.CargaAreas(cmbProveedor, FrmAlmacen.AlmacenActual.IdAlmacen.Contains("C") ? "C" : "N",
                                        '%' + cmbProveedor.Text.ToUpper() + '%');
                                txtProveedor.Text = string.Empty;
                                    if (cmbProveedor.Items.Count == 0)
                                    {
                                        cmbProveedor.Text = string.Empty;
                                        MessageBox.Show(@"Nombre de Area No Existe, Verifique . .",
                                                        @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                break;
                        }
                    }
                    break;
            }
        }

        private void txtCat2_KeyDown(object sender, KeyEventArgs e)
        {
            //Tab + Metodo = Enter
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.SuppressKeyPress = true;
                    if (txtCat2.TextLength > 0)
                    {
                        switch (strOpcion)
                        {
                            case "SalidaArea":
                                CatPartidaActual = SalidaService.CatPartidaDao.CargaPartida(txtCat2.Text);
                                if (CatPartidaActual != null)
                                {
                                    lblDesCat2.Text = CatPartidaActual.DesPartida;
                                    txtCat2.Enabled = false;
                                }
                                else
                                {
                                    lblDesCat2.Text = string.Empty;
                                    MessageBox.Show(@"No Existe la Partida, Verifique . . ",
                                            @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtCat2.Focus();
                                }
                                break;
                        }
                        
                    }
                    break;
            }
        }

        private void txtCat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtCat2,e);
        }
       
        private void FrmSelectDayToDay2Cat_Load(object sender, EventArgs e)
        {
            switch (strOpcion)
            {
                case "SalidaArea":
                    lblCat1.Text = @"Area";
                    lblCat2.Text = @"Partida";

                    var dtActual = SalidaService.EntradaDao.FechaServidor();
                    dtFechaIni.MaxDate = new DateTime(dtActual.Year, 12, 31);
                    dtFechaIni.Value = dtActual;
                    dtFechaIni.MinDate = new DateTime(dtActual.Year, 1, 1);

                    dtFechaFin.MaxDate = new DateTime(dtActual.Year, 12, 31);
                    dtFechaFin.Value = dtActual;
                    dtFechaFin.MinDate = new DateTime(dtActual.Year, 1, 1);
                    break;
            }
        }

        #endregion

        #region Metodos
        private void InicializarListas()
        {
            lblDesCat2.Text = string.Empty;
        }
        
        private void ImprimeEntradaProveedor(string strArea)
        {
            var salidaDetalles = SalidaService.SalidaDetalleDao.RptSalidaArea
                    (FrmAlmacen.AlmacenActual, dtFechaIni.Value, dtFechaFin.Value, strArea, CatAreaActual,
                        CatPartidaActual);

            if (salidaDetalles.Count != 0)
            {
                var lstSalidas = new List<rptDataSalidaArea>();
                foreach (var salidaDetalle in salidaDetalles)
                {
                    var objArticuloId = new ArticuloId((int) salidaDetalle[0], FrmAlmacen.AlmacenActual);
                    var objArticulo = SalidaService.ArticuloDao.Get(objArticuloId);

                    var salida = new rptDataSalidaArea()
                    {
                        DesArea = CatAreaActual==null?"TODAS":CatAreaActual.DesArea,
                        FechaIni = dtFechaIni.Value,
                        FechaFin = dtFechaFin.Value,
                        Partida = salidaDetalle[1].ToString(),
                        DesPartida = salidaDetalle[2].ToString(),
                        CveArt = objArticulo.Id.CveArt,
                        DesArticulo = objArticulo.DesArticulo,
                        Medida = objArticulo.CatUnidad,
                        Enero = salidaDetalle[3] == null ? 0 : Convert.ToDouble(salidaDetalle[3]),
                        Febrero = salidaDetalle[4] == null ? 0 : Convert.ToDouble(salidaDetalle[4]),
                        Marzo = salidaDetalle[5] == null ? 0 : Convert.ToDouble(salidaDetalle[5]),
                        Abril = salidaDetalle[6] == null ? 0 : Convert.ToDouble(salidaDetalle[6]),
                        Mayo = salidaDetalle[7] == null ? 0 : Convert.ToDouble(salidaDetalle[7]),
                        Junio = salidaDetalle[8] == null ? 0 : Convert.ToDouble(salidaDetalle[8]),
                        Julio = salidaDetalle[9] == null ? 0 : Convert.ToDouble(salidaDetalle[9]),
                        Agosto = salidaDetalle[10] == null ? 0 : Convert.ToDouble(salidaDetalle[10]),
                        Septiembre = salidaDetalle[11] == null ? 0 : Convert.ToDouble(salidaDetalle[11]),
                        Octubre = salidaDetalle[12] == null ? 0 : Convert.ToDouble(salidaDetalle[12]),
                        Noviembre = salidaDetalle[13] == null ? 0 : Convert.ToDouble(salidaDetalle[13]),
                        Diciembre = salidaDetalle[14] == null ? 0 : Convert.ToDouble(salidaDetalle[14])
                    };
                    lstSalidas.Add(salida);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstSalidas,
                    StrRptName = "rptSalidaArea",
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
