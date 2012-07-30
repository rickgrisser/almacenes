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
    public class FalloDaoImp : GenericDaoImp<Fallo, long >, IFalloDao
    {
        [Transaction(ReadOnly = true)]
        public IList<Object []> CargaFallos(int intAnio, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Fallo.CargaFallos");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.List<Object[]>();
        }

    }
}
