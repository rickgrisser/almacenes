using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Dao.ModCierre;
using Almacen.Data.Dao.ModEntrada;
using Almacen.Data.Dao.ModSalida;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.Seguridad;
using Almacen.Data.Entities;
using NHibernate;
using Spring.Transaction.Interceptor;
using System.Windows.Forms;

namespace Almacen.Business.ModSalida
{
    public class SalidaServiceImp : ISalidaService
    {
        public ISalidaDao SalidaDao { get; set; }
        public ISalidaDetalleDao SalidaDetalleDao { get; set; }
        public IUsuarioDao UsuarioDao { get; set; }
        public ICatAreaDao CatAreaDao { get; set; }
        public IArticuloDao ArticuloDao { get; set; }
        public IEntradaDetalleDao EntradaDetalleDao { get; set; }
        public IEntradaDao EntradaDao { get; set; }
        public ICostoPromedioDao CostoPromedioDao { get; set; }
        public ICierreDao CierreDao { get; set; }
        public ICatPartidaDao CatPartidaDao { get; set; }

        public void UsuariosAlmacen(ComboBox combo, string strAlmacen)
        {
            IList<Usuario> lstUsuario = UsuarioDao.CargaUsuarioxAlmacen(strAlmacen);
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.Nombre);
            Util.Dicc2Combo<Usuario, string>(dicc, combo);
        }

        public void CargaArea(ComboBox combo, string strTipo, int intCveArea)
        {
            IList<CatArea> lstUsuario = CatAreaDao.CargaArea(strTipo, intCveArea);
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.DesArea);
            Util.Dicc2Combo<CatArea, string>(dicc, combo);
        }

        public void CargaAreas(ComboBox combo, string strTipo, string strDesArea)
        {
            IList<CatArea> lstUsuario = CatAreaDao.CargaAreas(strTipo, strDesArea);
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.DesArea);
            Util.Dicc2Combo<CatArea, string>(dicc, combo);
        }

        [Transaction]
        public void GuardaSalida(ref Salida salida, bool blnModificacion)
        {
            //**********
            var salidasDetalleAct = new List<SalidaDetalle>();
            foreach (var salidaDetalle in salida.SalidaDetalle)
            {
                if (salidaDetalle.CantidadSurtida == 0)
                {
                    var objEntradaDetalle = EntradaDetalleDao.CargaDetalleXFechaExistencia0(
                            salidaDetalle.Articulo.Id.CveArt, salida.Almacen.IdAlmacen);
                    var objSalidaDetalle = new SalidaDetalle()
                        {
                            EntradaDetalle = objEntradaDetalle,
                            Articulo = salidaDetalle.Articulo,
                            CantidadPedida = salidaDetalle.CantidadPedida,
                            CantidadSurtida = objEntradaDetalle.Existencia,
                            FechaCaducidad = objEntradaDetalle.FechaCaducidad,
                            NoLote = objEntradaDetalle.NoLote,
                            CatActividad = objEntradaDetalle.Entrada.CatActividad,
                            CatPresupuesto = objEntradaDetalle.Entrada.CatPresupuesto
                        };
                    salidasDetalleAct.Add(objSalidaDetalle);
                }
                else
                {
                    while (salidaDetalle.CantidadSurtida > 0)
                    {
                        var objEntradaDetalle = EntradaDetalleDao.CargaDetalleXFechaExistencia(
                            salidaDetalle.Articulo.Id.CveArt, salida.Almacen.IdAlmacen);
                        decimal decTmp;
                        if (objEntradaDetalle.Existencia <= salidaDetalle.CantidadSurtida)
                        {
                            decTmp = (decimal)objEntradaDetalle.Existencia;
                            salidaDetalle.CantidadSurtida = salidaDetalle.CantidadSurtida - objEntradaDetalle.Existencia;
                            objEntradaDetalle.Existencia = 0;
                        }
                        else
                        {
                            decTmp = (decimal)salidaDetalle.CantidadSurtida;
                            objEntradaDetalle.Existencia = objEntradaDetalle.Existencia - salidaDetalle.CantidadSurtida;
                            salidaDetalle.CantidadSurtida = 0;
                        }
                        EntradaDetalleDao.Update(objEntradaDetalle);
                        var objSalidaDetalle = new SalidaDetalle()
                        {
                            EntradaDetalle = objEntradaDetalle,
                            Articulo = salidaDetalle.Articulo,
                            CantidadPedida = salidaDetalle.CantidadPedida,
                            CantidadSurtida = decTmp,
                            FechaCaducidad = objEntradaDetalle.FechaCaducidad,
                            NoLote = objEntradaDetalle.NoLote,
                            CatActividad = objEntradaDetalle.Entrada.CatActividad,
                            CatPresupuesto = objEntradaDetalle.Entrada.CatPresupuesto
                        };
                        salidasDetalleAct.Add(objSalidaDetalle);
                    }
                }
            }

            //**********
            short intRenglon = 1;
            foreach (var salidaDetalle in salidasDetalleAct)
            {
                salidaDetalle.RenglonSalida = intRenglon++;
                salidaDetalle.Salida = salida;
                salidaDetalle.CostoPromedio = CostoPromedioDao.CostoPromedio(salidaDetalle.Articulo.Id.CveArt,
                                                                             salidaDetalle.Salida.Almacen.IdAlmacen);
            }
            salida.SalidaDetalle = salidasDetalleAct;
            
            salida.Modificacion=salida.Modificacion==null?1:salida.Modificacion++;
            salida = SalidaDao.Merge(salida);
            
        }

        [Transaction(ReadOnly = true)]
        public Salida CargaSalida(int intAnio, string strAlmacen, int intNumeroSalida, int intIdUsuario)
        {
            var cargaSalida = SalidaDao.CargaSalida(intAnio, strAlmacen, intNumeroSalida, intIdUsuario);
            if (cargaSalida != null)
            {
                var salidasDetalle = cargaSalida.SalidaDetalle;
                foreach (var salidaDetalle in salidasDetalle)
                {
                    salidaDetalle.Existencia = EntradaDetalleDao.ExistenciaTotal(salidaDetalle.Articulo.Id.CveArt,
                                                                                 strAlmacen);
                }
            }
            return cargaSalida;
        }

        [Transaction]
        public Salida BorraSalida(ref Salida salida)
        {
            var salidasDetalle = salida.SalidaDetalle;
            //var intRenglon = 1;
            foreach (var salidaDetalle in salidasDetalle)
            {
                //samsung
                //var salidaDetalleId = new SalidaDetalleId()
                //{
                //    Salida = salida,
                //    RenglonSalida = intRenglon++
                //};
                //salidaDetalle.Id = salidaDetalleId;

                var objEntradaDetalle = EntradaDetalleDao.Get(salidaDetalle.EntradaDetalle.IdEntradaDetalle);
                objEntradaDetalle.Existencia = objEntradaDetalle.Existencia + salidaDetalle.CantidadSurtida;
                EntradaDetalleDao.Update(objEntradaDetalle);
            }
            SalidaDao.Delete(salida);
            return salida;
        }
    }
}

