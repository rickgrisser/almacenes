using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModSalida
{
    public class SalidaDetalleDaoImp : GenericDaoImp<SalidaDetalle, long>, ISalidaDetalleDao
    {
        [Transaction(ReadOnly = true)]
        public bool SalidaExiste(long intIdEntrada)
        {
            var result = false;
            var query = CurrentSession.GetNamedQuery("SalidaDetalle.SalidaExiste");
            query.SetParameter("intIdEntrada", intIdEntrada);
            if(query.UniqueResult<Int64>()>0)
            {
                result = true;
            }
            return result;
        }

        [Transaction(ReadOnly = true)]
        public IList<SalidaDetalle> CargaSalidaDetalles(long intIdSalida, int intCveArt)
        {
            var query = CurrentSession.GetNamedQuery("SalidaDetalle.CargaSalidaDetalle");
            query.SetParameter("intIdSalida", intIdSalida);
            query.SetParameter("intCveArt", intCveArt);
            return query.List<SalidaDetalle>();
        }

        [Transaction(ReadOnly = true)]
        public bool MovimientosPosteriores(string strAlmacen, Collection<int> strArticulos, DateTime strFecha)
        {
            var result = false;
            var query = CurrentSession.GetNamedQuery("SalidaDetalle.MovimientosPosteriores");
            query.SetParameterList("strArticulos", strArticulos.ToList());
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("strFecha", strFecha);
            if (query.UniqueResult<Int64>() > 0)
            {
                result = true;
            }
            return result;
        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> CargaSumSurtida(long intIdSalida)
        {
            var query = CurrentSession.GetNamedQuery("SalidaDetalle.CargaSumSurtida");
            query.SetParameter("intIdSalida", intIdSalida);
            return query.List<object[]>();
        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptSalidaVale(long intNumSalida, int intAnio, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("SalidaDetalle.RptSalidaVale");
            query.SetParameter("intNumSalida", intNumSalida);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptSalidaPartida(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("SalidaDetalle.RptSalidaPartida");
            query.SetParameter("datFechaIni", datFechaIni);
            query.SetParameter("datFechaFin", datFechaFin);
            query.SetParameter("objAlmacen", objAlmacen);
            return query.List<object[]>();
        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptSalidaFolioPartida(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("SalidaDetalle.RptSalidaFolioPartida");
            query.SetParameter("datFechaIni", datFechaIni);
            query.SetParameter("datFechaFin", datFechaFin);
            query.SetParameter("objAlmacen", objAlmacen);
            return query.List<object[]>();
        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptSalidaDetallado(Entities.Almacen objAlmacen, string strSalidaFecha,
                    string strSalidaFolio, string strSituacion, string strCatArea, CatArea objCatArea)
        {
            var strSql = "Select sd.Salida.FechaSalida, sd.Salida.NumeroSalida, " +
                    "sd.Salida.CatArea.DesArea, sd.Articulo.Id.CveArt, sd.Articulo.DesArticulo, " +
                    "sd.CantidadSurtida, sd.CostoPromedio, sd.FechaCaducidad, " +
                    "year(sd.EntradaDetalle.Entrada.FechaEntrada), sd.EntradaDetalle.Entrada.NumeroEntrada, " +
                    "sd.Salida.EstadoSalida " +
                "from SalidaDetalle sd " +
                "where " +
                    strSalidaFecha + 
                    strSalidaFolio +
                    strSituacion +
                    strCatArea +
                "sd.Salida.Almacen=:objAlmacen " +
                "order by 2,4";
            var query = CurrentSession.CreateQuery(strSql);
            query.SetParameter("objAlmacen", objAlmacen);
            if (strCatArea.Length > 0)
            { query.SetParameter("objCatArea", objCatArea); }
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptSalidaFolio(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("SalidaDetalle.RptSalidaFolio");
            query.SetParameter("datFechaIni", datFechaIni);
            query.SetParameter("datFechaFin", datFechaFin);
            query.SetParameter("objAlmacen", objAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptSalidaArea(Entities.Almacen objAlmacen, DateTime datFechaIni, DateTime datFechaFin,
                    string strArea, CatArea objCatArea, CatPartida objCatPartida)
        {
            var strSql = "select sd.Articulo.Id.CveArt, ap.Id.CatPartida.Partida, ap.Id.CatPartida.DesPartida, " +
                     "sum(case month(sd.Salida.FechaSalida) when 1 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 2 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 3 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 4 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 5 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 6 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 7 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 8 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 9 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 10 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 11 then sd.CantidadSurtida end), " +
                     "sum(case month(sd.Salida.FechaSalida) when 12 then sd.CantidadSurtida end) " +
                "from SalidaDetalle sd, ArticuloPartida ap " +              
                "where " +
                        strArea +
                    "sd.Salida.FechaSalida between :datFechaIni and :datFechaFin " +
                    "and sd.Salida.Almacen = :objAlmacen " +
                    "and (sd.Salida.EstadoSalida <> 'C' or sd.Salida.EstadoSalida is null) " +
                    "and (ap.Id.Articulo=sd.Articulo and ap.FechaFin is null and ap.Id.CatPartida=:objCatPartida) " +
                "group by 1,2,3 " +
                "order by 1";

            var query = CurrentSession.CreateQuery(strSql);
            query.SetParameter("datFechaIni", datFechaIni);
            query.SetParameter("datFechaFin", datFechaFin);
            query.SetParameter("objAlmacen", objAlmacen);
            query.SetParameter("objCatPartida", objCatPartida);
            if (strArea.Length > 0)
            { query.SetParameter("objCatArea", objCatArea); }
            return query.List<object[]>();

        }
    }
}
