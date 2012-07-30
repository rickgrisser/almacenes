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
    public class CatPresupuestoDaoImp : GenericDaoImp<CatPresupuesto, int>, ICatPresupuestoDao
    {
        [Transaction(ReadOnly = true)]
        public IList<CatPresupuesto> CargaPresupuesto()
        {
            var query = CurrentSession.GetNamedQuery("CatPresupuesto.Carga");
            return query.List<CatPresupuesto>();
        }
    }
}
