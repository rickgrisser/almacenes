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
    public class TipoMedicamentoDaoImp : GenericDaoImp<TipoMedicamento, int>, ITipoMedicamentoDao
    {
        [Transaction(ReadOnly = true)]
        public IList<TipoMedicamento> CargaTipos()
        {
            var query = CurrentSession.GetNamedQuery("TipoMedicamento.Carga");
            return query.List<TipoMedicamento>();
        }
    }
}
