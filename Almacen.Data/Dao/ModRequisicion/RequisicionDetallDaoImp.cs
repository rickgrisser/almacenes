using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModRequisicion
{
    public class RequisicionDetallDaoImp : GenericDaoImp<RequisicionDetall, long>, IRequisicionDetallDao
    {
        [Transaction(ReadOnly = true)]
        public decimal Cantidad(long intIdRequisicion, int intCveArt)
        {
            var query = CurrentSession.GetNamedQuery("RequisicionDetalle.Cantidad");
            query.SetParameter("intIdRequisicion", intIdRequisicion);
            query.SetParameter("intCveArt", intCveArt);
            return query.UniqueResult<decimal>();
        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptRequisicionVale(int intNumRequisicion, int intAnio, Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("RequisicionDetalle.RptRequisicionVale");
            query.SetParameter("intNumRequisicion", intNumRequisicion);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("objAlmacen", objAlmacen);
            return query.List<object[]>();

        }
    }
}
