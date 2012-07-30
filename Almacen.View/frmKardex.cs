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
    public partial class FrmKardex : Form
    {
        #region Variables Miembro

        public string strOpcion;
        private IEntradaService EntradaService;
        //private ISalidaService SalidaService;
        private CatPartida CatPartidaActual;
        private DateTime dtFechaIni;
        #endregion

        #region Contructores
        public FrmKardex()
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
            dtFechaIni = new DateTime((int)cmbAnio.Value, (int)cmbMes.SelectedValue,1);
            if (dtFechaFin.Value >= dtFechaIni)
            {
               switch (strOpcion)
                {
                    case "Kardex":
                        Kardex();
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
                        }
                        else
                        {
                            lblDesPartida.Text = string.Empty;
                            MessageBox.Show(@"No Existe la Partida, Verifique . . ",
                                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPartida.Focus();
                        }
                    }
                    break;
            }
        }

        private void txtPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtPartida, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtArtIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtArtIni, e);
        }

        private void txtArtFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fx.OnNumeric(txtArtFin, e);
        }

        private void txtArtIni_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtArtIni, e);
        }

        private void txtArtFin_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtArtFin, e);
        }

        #endregion

        #region Metodos
        private void InicializarListas()
        {
            
            cmbMes.DisplayMember = "Name";
            cmbMes.ValueMember = "Value";
            cmbMes.DataSource = Fx.Meses();
            cmbMes.SelectedIndex = 0;

            FechaActual();
            Limpiar();
        }

        private void FechaActual()
        {
            var dtActual = EntradaService.EntradaDao.FechaServidor();
            cmbAnio.Maximum = dtActual.Year;
            cmbAnio.Value = dtActual.Year;
            cmbAnio.Minimum = dtActual.Year - 1;

            dtFechaFin.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFechaFin.Value = dtActual;
            dtFechaFin.MinDate = new DateTime(dtActual.Year - 1, 1, 1);
        }

        private void Kardex()
        {

            if (txtArtIni.TextLength > 0 && txtArtFin.TextLength >0 && CatPartidaActual!=null)
            {
                //Partida y Rango de Articulos
                ImprimeKardex(EntradaService.EntradaDetalleDao.RptKardexFull
                                (dtFechaIni, dtFechaFin.Value, Int32.Parse(txtArtIni.Text), Int32.Parse(txtArtFin.Text),
                                CatPartidaActual.Partida, FrmAlmacen.AlmacenActual.IdAlmacen));
            }
            else if(CatPartidaActual!=null)
            {
                //Partida
                ImprimeKardex(EntradaService.EntradaDetalleDao.RptKardexPartida
                                (dtFechaIni, dtFechaFin.Value, CatPartidaActual.Partida,FrmAlmacen.AlmacenActual.IdAlmacen));
            }
            else if (txtArtIni.TextLength > 0 && txtArtFin.TextLength > 0)
            {
                //Rango de Articulos
                if(Int32.Parse(txtArtIni.Text)<=Int32.Parse(txtArtFin.Text) &&
                        Int32.Parse(txtArtIni.Text)>0 && Int32.Parse(txtArtFin.Text)>0)
                {
                    ImprimeKardex(EntradaService.EntradaDetalleDao.RptKardexArticulos
                                (dtFechaIni, dtFechaFin.Value, Int32.Parse(txtArtIni.Text), Int32.Parse(txtArtFin.Text),
                                FrmAlmacen.AlmacenActual.IdAlmacen));
                }
                else
                {
                    MessageBox.Show(@"Rango de Articulos Incorrecto, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Rango Fechas
                ImprimeKardex(EntradaService.EntradaDetalleDao.RptKardexFechas
                                (dtFechaIni, dtFechaFin.Value, FrmAlmacen.AlmacenActual.IdAlmacen));
            }


            //var kardexDetalles = EntradaService.EntradaDetalleDao.RptKardex
            //        (dtFechaIni, dtFechaFin.Value,Int32.Parse(txtArtIni.Text),Int32.Parse(txtArtFin.Text),
            //        FrmAlmacen.AlmacenActual.IdAlmacen);

            
            
        }


        private void ImprimeKardex(IList<object []> kardexDetalles)
        {
            if (kardexDetalles.Count != 0)
            {
                var lstKardex = new List<rptDataKardex>();
                var intTmp = 0;
                var intCveArt = 0;
                var douExistencia = 0.0;
                var douSaldo = 0.0;
                foreach (var kardexDetalle in kardexDetalles)
                {
                    intTmp++;
                    var idArticulo = new ArticuloId()
                    {
                        Almacen = FrmAlmacen.AlmacenActual,
                        CveArt = (int)kardexDetalle[3]
                    };
                    var desArticulo = EntradaService.ArticuloDao.Get(idArticulo).DesArticulo;
                    //Inserta Cierre

                    var objCierre = new Cierre();
                    if (intTmp == 1 || (intCveArt != (int)kardexDetalle[3]))
                    {
                        //Consulta Cierre
                        var cierreId = new CierreId()
                        {
                            FechaCierre = dtFechaIni.AddDays(-1),
                            Articulo = EntradaService.ArticuloDao.Get(idArticulo)
                        };
                        objCierre = EntradaService.CierreDao.Get(cierreId);

                        var Cierre = new rptDataKardex()
                        {
                            FechaIni = dtFechaIni,
                            FechaFin = dtFechaFin.Value,
                            DesArticulo = desArticulo,
                            CvePartida = kardexDetalle[1].ToString(),
                            DesPartida = kardexDetalle[2].ToString(),
                            CveArt = (int)kardexDetalle[3],
                            Unidad = kardexDetalle[4].ToString(),
                            Presentacion = kardexDetalle[5] == null ? "" : kardexDetalle[5].ToString(),
                            PresentacionCant = kardexDetalle[6] == null ? "" : kardexDetalle[6].ToString(),
                            PresentacionUnid = kardexDetalle[7] == null ? "" : kardexDetalle[7].ToString(),
                            Fecha = dtFechaIni.AddDays(-1),
                            Folio = -1,
                            //CantEntrada = objCierre == null ? 0 : Convert.ToDouble(objCierre.Existencia),
                            CantSalida = -1,
                            //Existencia = objCierre == null ? 0 : Convert.ToDouble(objCierre.Existencia),
                            //PrecioEntrada = objCierre == null ? 0 : Convert.ToDouble(objCierre.Importe),
                            PrecioSalida = -1,
                            //Debe = objCierre == null ? 0 : Convert.ToDouble(objCierre.Existencia * objCierre.Importe),
                            //Saldo = objCierre == null ? 0 : Convert.ToDouble(objCierre.Existencia * objCierre.Importe),
                            Haber = -1,
                            Area = @"EXISTENCIA AL " + dtFechaIni.AddDays(-1).ToShortDateString()
                        };
                        if(objCierre==null)
                        {
                            Cierre.CantEntrada = 0;
                            Cierre.Existencia = 0;
                            Cierre.PrecioEntrada = 0;
                            Cierre.Debe = 0;
                            Cierre.Saldo = 0;
                        }
                        else
                        {
                            Cierre.CantEntrada = Convert.ToDouble(objCierre.Existencia);
                            Cierre.Existencia = Convert.ToDouble(objCierre.Existencia);
                            Cierre.PrecioEntrada = Convert.ToDouble(objCierre.Importe);
                            Cierre.Debe = Convert.ToDouble(objCierre.Existencia * objCierre.Importe);
                            Cierre.Saldo = Convert.ToDouble(objCierre.Existencia * objCierre.Importe);
                        }
                        lstKardex.Add(Cierre);
                    }

                    var kardex = new rptDataKardex()
                    {
                        FechaIni = dtFechaIni,
                        FechaFin = dtFechaFin.Value,
                        DesArticulo = desArticulo,
                        CvePartida = kardexDetalle[1].ToString(),
                        DesPartida = kardexDetalle[2].ToString(),
                        CveArt = (int)kardexDetalle[3],
                        Unidad = kardexDetalle[4].ToString(),
                        Presentacion = kardexDetalle[5] == null ? "" : kardexDetalle[5].ToString(),
                        PresentacionCant = kardexDetalle[6] == null ? "" : kardexDetalle[6].ToString(),
                        PresentacionUnid = kardexDetalle[7] == null ? "" : kardexDetalle[7].ToString(),
                        Fecha = DateTime.Parse(kardexDetalle[8].ToString()),
                        Pedido = kardexDetalle[9] == null ? 0 : (int)kardexDetalle[9],
                        Folio = (int)kardexDetalle[10],
                        CantEntrada = Convert.ToDouble(kardexDetalle[11]),
                        CantSalida = Convert.ToDouble(kardexDetalle[12]),
                        PrecioEntrada = Convert.ToDouble(kardexDetalle[13]),
                        PrecioSalida = Convert.ToDouble(kardexDetalle[14]),
                        Debe = Convert.ToDouble(kardexDetalle[15]),
                        Haber = Convert.ToDouble(kardexDetalle[16]),
                        Area = kardexDetalle[17].ToString(),
                        TipoPedido = kardexDetalle[18] == null ? -1 : (int)kardexDetalle[18]
                    };
                    if (intTmp == 1 || intCveArt != (int)kardexDetalle[3])
                    {
                        intCveArt = (int)kardexDetalle[3];
                        if(objCierre==null)
                        {
                            douExistencia = 0;
                            douSaldo = 0;
                        }
                        else
                        {
                            douExistencia = Convert.ToDouble(objCierre.Existencia);
                            douSaldo = Convert.ToDouble(objCierre.Existencia * objCierre.Importe);
                        }
                        //douExistencia = objCierre == null ? 0 : Convert.ToDouble(objCierre.Existencia);
                        //douSaldo = objCierre == null ? 0 : Convert.ToDouble(objCierre.Existencia * objCierre.Importe);

                        //douExistencia = kardexDetalle[0].ToString() == "E" ?
                        //            douExistencia + Convert.ToDouble(kardexDetalle[11]) :
                        //            douExistencia - Convert.ToDouble(kardexDetalle[12]);

                    }
                    //else
                    //{
                    //    if(intCveArt!=(int) kardexDetalle[3])
                    //    {
                    //        intCveArt = (int)kardexDetalle[3];
                    //        douExistencia = 0.0;
                    //        douSaldo = 0.0;
                    //douExistencia = kardexDetalle[0].ToString() == "E" ?
                    //       douExistencia + Convert.ToDouble(kardexDetalle[11]) :
                    //       douExistencia - Convert.ToDouble(kardexDetalle[12]);
                    //}
                    //else
                    //{
                    //    intCveArt = (int)kardexDetalle[3];
                    //    douExistencia = 0.0;
                    //    //douExistencia = kardexDetalle[0].ToString() == "E" ?
                    //    //            douExistencia + Convert.ToDouble(kardexDetalle[11]) :
                    //    //            douExistencia - Convert.ToDouble(kardexDetalle[12]);
                    //}
                    //}

                    douExistencia = kardexDetalle[0].ToString() == "E" ?
                                douExistencia + Convert.ToDouble(kardexDetalle[11]) :
                                douExistencia - Convert.ToDouble(kardexDetalle[12]);

                    douSaldo = kardexDetalle[0].ToString() == "E" ?
                                douSaldo + Convert.ToDouble(kardexDetalle[15]) :
                                douSaldo - Convert.ToDouble(kardexDetalle[16]);

                    kardex.Existencia = douExistencia;
                    kardex.Saldo = douSaldo;
                    lstKardex.Add(kardex);
                }
                var formaVisor = new FrmCrVisor
                {
                    ObjList = lstKardex,
                    StrRptName = "rptKardex",
                    StrTitle = "ALMACEN DE " + FrmAlmacen.AlmacenActual.DesAlmacen
                };
                formaVisor.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"No Existen Entradas/Salidas, Verifique . .",
                                @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            FechaActual();
            CatPartidaActual= null;

            cmbMes.SelectedIndex = 0;
            txtPartida.Text = string.Empty;
            lblDesPartida.Text = string.Empty;
            txtPartida.Enabled = true;

            txtArtIni.Text = string.Empty;
            txtArtFin.Text = string.Empty;
        }

       
        #endregion

        

    }
}
