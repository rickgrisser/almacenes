using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModEntrada
{
    public class CostoPromedioDaoImp : GenericDaoImp<CostoPromedio, CostoPromedioId>, ICostoPromedioDao
    {
        [Transaction(ReadOnly = true)]
        public decimal CostoPromedio(int intCveArt, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("CostoPromedio.CargaCostoPromedio");
            query.SetParameter("intCveArt", intCveArt);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<decimal>();
        }
    }
}
