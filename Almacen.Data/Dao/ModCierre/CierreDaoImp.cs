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
    public class CierreDaoImp : GenericDaoImp<Cierre, CierreId>, ICierreDao
    {
        [Transaction(ReadOnly = true)]
        public bool CierreExiste(string strAlmacen, int intMes, int intAnio)
        {
            var result = false;
            var query = CurrentSession.GetNamedQuery("Cierre.ExisteCierre");
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intMes", intMes);
            query.SetParameter("intAnio", intAnio);
            if (query.UniqueResult<Int64>() > 0)
            {
                result = true;
            }
            return result;
        }

        [Transaction(ReadOnly = true)]
        public Cierre CargaCierrexArticulo(int intCveArt, string strAlmacen, int intMes, int intAnio)
        {
            var query = CurrentSession.GetNamedQuery("Cierre.CargaCierre");
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intMes", intMes);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("intCveArt", intCveArt);
            return query.UniqueResult<Cierre>();
        }

        [Transaction(ReadOnly = true)]
        public DateTime CargaUltimaFecha(string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Cierre.CargaUltimaFecha");
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<DateTime>();
        }

        [Transaction(ReadOnly = true)]
        public bool CierreMesAnteriorExiste(string strAlmacen, int intMes, int intAnio)
        {
            var result = false;
            var query = CurrentSession.GetNamedQuery("Cierre.ExisteCierre");
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intMes", intMes==1?12:intMes-1);
            query.SetParameter("intAnio", intMes==1?intAnio-1:intAnio);
            
            if (query.UniqueResult<Int64>() > 0)
            {
                result = true;
            }
            return result;
        }

        [Transaction(ReadOnly = true)]
        public IList<DateTime> CargaFechasCierres(int intAnio, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Cierre.CargaFechasCierres");
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intAnio", intAnio);
            return query.List<DateTime>();
        }

        [Transaction(ReadOnly = true)]
        public IList<Cierre> CargaCierreXAlmacen(string strAlmacen, int intMes, int intAnio)
        {
            var query = CurrentSession.GetNamedQuery("Cierre.CargaCierreXAlmacen");
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("intMes", intMes);
            return query.List<Cierre>();
        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptCierre(int intMes, int intAnio, string strAlmacen, bool bolOpcion)
        {
            var query = bolOpcion
                            ? CurrentSession.GetNamedQuery("Cierre.RptCierre")
                            : CurrentSession.GetNamedQuery("Cierre.RptCierreConySin");
            query.SetParameter("intMes", intMes);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptCierreXPartida(int intMes, int intAnio, string strAlmacen, string strPartida, bool bolOpcion)
        {
            var query = bolOpcion
                            ? CurrentSession.GetNamedQuery("Cierre.RptCierreXPartida")
                            : CurrentSession.GetNamedQuery("Cierre.RptCierreXPartidaConySin");
            query.SetParameter("intMes", intMes);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("strPartida", strPartida);
            return query.List<object[]>();

        }
    }
}
