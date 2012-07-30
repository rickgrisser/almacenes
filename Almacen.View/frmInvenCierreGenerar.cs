using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Almacen.Data.Entities;
using Spring.Context;
using Spring.Context.Support;
using Almacen.Business.ModCierre;
using Almacen.Business;
namespace Almacen.View
{
    public partial class FrmInvenCierreGenerar : Form
    { 


        #region Constructores
        public FrmInvenCierreGenerar()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            CierreService = ctx["cierreService"] as ICierreService;
            lblProgress.Text = "";
            InicializarListas();
        }
        #endregion

        #region Variables Miembro
        public ICierreService CierreService;
        #endregion


        #region Eventos

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCierre();
        }

        #region Metodos

        private void InicializarListas()
        {
            var dtActual = CierreService.CierreDao.FechaServidor();
            dtFechaCierre.MaxDate = new DateTime(dtActual.Year, 12, 31);
            dtFechaCierre.Value = dtActual;
            //dtFechaCierre.MinDate = dtActual.Month == 1 ? new DateTime(dtActual.Year - 1, 12, 1) : new DateTime(dtActual.Year, 1, 1);
        }

        private void GuardarCierre()
        {
            if (CierreService.CierreDao.CierreExiste(FrmAlmacen.AlmacenActual.IdAlmacen,dtFechaCierre.Value.Month,
                dtFechaCierre.Value.Year))
            {
                MessageBox.Show(@"Ya Existe Cierre de Mes, Verifique . . ",
                                       @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtFechaCierre.Focus();
            }
            else
            {
                if (CierreService.CierreDao.CierreMesAnteriorExiste(FrmAlmacen.AlmacenActual.IdAlmacen,dtFechaCierre.Value.Month,
                dtFechaCierre.Value.Year))
                {
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    GeneraCierre();
                }
                else
                {
                    MessageBox.Show(@"No Existe Cierre del Mes Anterior, Verifique . . ",
                                       @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GeneraCierre()
        {
            try
            {
                var lstArticulos =
                            CierreService.ArticuloDao.CargaArticulosXAlmacen(FrmAlmacen.AlmacenActual.IdAlmacen);
                var dtCierre = CierreService.CierreDao.CargaUltimaFecha(FrmAlmacen.AlmacenActual.IdAlmacen);
                var intCount = 0;
                foreach (var objArticulo in lstArticulos)
                {
                    intCount++;
                    //Busca Cierre Anterior
                    var objCierre = CierreService.CierreDao.CargaCierrexArticulo(objArticulo.Id.CveArt,
                        FrmAlmacen.AlmacenActual.IdAlmacen, dtCierre.Month, dtCierre.Year);
                    //Busca Entradas Salidas y Calcula
                    decimal[] tm = CierrePaso(objArticulo, dtCierre.AddDays(1),dtFechaCierre.Value,
                        objCierre == null ? 0 : (decimal)objCierre.Existencia, objCierre == null ? 0 : objCierre.Importe, FrmAlmacen.AlmacenActual);

                    var cierreId = new CierreId(dtFechaCierre.Value,objArticulo);
                    var cierre = new Cierre(cierreId)//,tm[1])
                            {
                                Existencia = tm[0],
                                FechaAlta = CierreService.CierreDao.FechaServidor(),
                                Usuario = FrmAcceso.UsuarioLog,
                                Estatus = "A"
                            };
                    CierreService.CierreDao.Update(cierre);
                    double doulst = lstArticulos.Count;
                    double dProgressPercentage = intCount / doulst;
                    var iProgressPercentage = (int)(dProgressPercentage * 100);                    
                    lblProgress.Text = intCount + @"/" + doulst + @"   " + iProgressPercentage + @"% Completado";
                    lblProgress.Refresh();
                    pbCierre.Value = iProgressPercentage;
                    pbCierre.Refresh();
                }
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion del Cierre "  + ee.Message,
                    @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal[] CierrePaso(Articulo articulo, DateTime dtFechaIni, DateTime dtFechaFin, decimal decExistencia,
                                        decimal decCosto, Data.Entities.Almacen almacen)
        {
            //Delete from ult_cpf=cierrepaso where almacen=xalma
                //var lstCierrePaso = CierreService.CierrePasoDao.CargaCierrePaso(almacen.IdAlmacen);
                //CierreService.BorraCierrePaso(ref lstCierrePaso);

                //Busca Entradas
                var lstEntradas = CierreService.CierrePasoDao.CargaEntradas(articulo.Id.CveArt, dtFechaIni, dtFechaFin,
                                                                             almacen.IdAlmacen);
                foreach (var objEntrada in lstEntradas)
                {
                    var CierrePasoId = new CierrePasoId(Convert.ToDateTime(objEntrada[3]), articulo, (long)objEntrada[0],"E");
                    var CierrePaso = new CierrePaso(CierrePasoId)
                                         {
                                             Cantidad = (decimal) objEntrada[1],
                                             CostoP = (decimal) objEntrada[2]
                                         };
                    CierreService.CierrePasoDao.Update(CierrePaso);
                }

                //Busca Salidas
                var lstSalidas = CierreService.CierrePasoDao.CargaSalidas(articulo.Id.CveArt, dtFechaIni, dtFechaFin,
                                                                       almacen.IdAlmacen);
                foreach (var objSalida in lstSalidas)
                {
                    var CierrePasoId = new CierrePasoId(Convert.ToDateTime(objSalida[3]), articulo, (long)objSalida[0], "S");
                    var CierrePaso = new CierrePaso(CierrePasoId)
                                         {
                                             Cantidad = (decimal)objSalida[1],
                                             CostoP = (decimal)objSalida[2]
                                         };
                    CierreService.CierrePasoDao.Update(CierrePaso);
                }

                //Calcula
                var lstCierrePaso = CierreService.CierrePasoDao.CargaCierrePaso(almacen.IdAlmacen);
                foreach (var cierrePaso in lstCierrePaso)
                {
                    if (cierrePaso.Id.EntSal == "S")
                    {
                        decExistencia = (decimal) (decExistencia - cierrePaso.Cantidad);
                        //update salida_detalle
                        var objSalidaDetalles = CierreService.SalidaDetalleDao.CargaSalidaDetalles(
                            (int) cierrePaso.Id.Llave, articulo.Id.CveArt);
                        foreach (var salidaDetalle in objSalidaDetalles)
                        {
                            salidaDetalle.CostoPromedio = decCosto;
                            CierreService.SalidaDetalleDao.Update(salidaDetalle);
                        }
                    }
                    else
                    {
                        if (decExistencia <= 0)
                        {
                            decCosto = (decimal) cierrePaso.CostoP;
                            decExistencia = (decimal) (decExistencia + cierrePaso.Cantidad);
                        }
                        else
                        {
                            decCosto = (decimal) (((decExistencia*decCosto) + (cierrePaso.Cantidad*cierrePaso.CostoP))
                                                  /(decExistencia + cierrePaso.Cantidad));
                            decExistencia = (decimal) (decExistencia + cierrePaso.Cantidad);
                        }
                    }
                }

                if (decExistencia > 0 || decCosto > 0)
                {
                    var objArticuloId = new ArticuloId(articulo.Id.CveArt, almacen);
                    var objArticulo = CierreService.ArticuloDao.Get(objArticuloId);
                    objArticulo.MovimientoProm = decCosto;
                    CierreService.ArticuloDao.Update(objArticulo);
                }

                //Delete from ult_cpf=cierrepaso where almacen=xalma
                //lstCierrePaso = CierreService.CierrePasoDao.CargaCierrePaso(almacen.IdAlmacen);
                CierreService.BorraCierrePaso(ref lstCierrePaso);
                
            return new[] {decExistencia, decCosto};
        }
     
        #endregion
        
    }
}
