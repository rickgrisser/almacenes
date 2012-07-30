using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModCierre
{
    public class CierrePasoDaoImp : GenericDaoImp<CierrePaso, CierrePasoId>, ICierrePasoDao
    {
        [Transaction(ReadOnly = true)]
        public IList<CierrePaso> CargaCierrePaso(string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("CierrePaso.CargaCierrePaso");
            query.SetParameter("strAlmacen", strAlmacen);
            return query.List<CierrePaso>();
        }

        //[Transaction(ReadOnly = true)]
        //public IList<EntradaDetalle> CargaEntradas(int intCveArt, DateTime dtFechaIni, DateTime dtFechaFin, string strAlmacen)
        //{
        //    var query = CurrentSession.GetNamedQuery("CierrePaso.CargaEntradas");
        //    query.SetParameter("strAlmacen", strAlmacen);
        //    query.SetParameter("dtFechaIni", dtFechaIni);
        //    query.SetParameter("dtFechaFin", dtFechaFin);
        //    query.SetParameter("intCveArt", intCveArt);
        //    return query.List<EntradaDetalle>();
        //}

        //[Transaction(ReadOnly = true)]
        //public IList<SalidaDetalle> CargaSalidas(int intCveArt, DateTime dtFechaIni,  DateTime dtFechaFin, string strAlmacen)
        //{
        //    var query = CurrentSession.GetNamedQuery("CierrePaso.CargaSalidas");
        //    query.SetParameter("strAlmacen", strAlmacen);
        //    query.SetParameter("dtFechaIni", dtFechaIni);
        //    query.SetParameter("dtFechaFin", dtFechaFin);
        //    query.SetParameter("intCveArt", intCveArt);
        //    return query.List<SalidaDetalle>();
        //}

        [Transaction(ReadOnly = true)]
        public IList<object []> CargaEntradas(int intCveArt, DateTime dtFechaIni, DateTime dtFechaFin, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("CierrePaso.CargaEntradas");
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("dtFechaIni", dtFechaIni);
            query.SetParameter("dtFechaFin", dtFechaFin);
            query.SetParameter("intCveArt", intCveArt);
            return query.List<object[]>();
        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> CargaSalidas(int intCveArt, DateTime dtFechaIni, DateTime dtFechaFin, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("CierrePaso.CargaSalidas");
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("dtFechaIni", dtFechaIni);
            query.SetParameter("dtFechaFin", dtFechaFin);
            query.SetParameter("intCveArt", intCveArt);
            return query.List<object[]>();
        }
        
    }
}
