using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.Catalogos
{
    public class CatUnidadDaoImp : GenericDaoImp<CatUnidad, string >, ICatUnidadDao
    {
        [Transaction(ReadOnly = true)]
        public IList<CatUnidad> CargaUnidades()
        {
            var query = CurrentSession.GetNamedQuery("CatUnidad.CargaUnidades");
            return query.List<CatUnidad>();
        }
    }
}
