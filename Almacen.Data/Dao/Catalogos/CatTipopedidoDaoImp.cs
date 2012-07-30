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
    public class CatTipopedidoDaoImp : GenericDaoImp<CatTipopedido, int>, ICatTipopedidoDao
    {
        [Transaction(ReadOnly = true)]
        public IList<CatTipopedido> CargaTipoPedidos()
        {
            var query = CurrentSession.GetNamedQuery("CatTipopedido.Carga");
            return query.List<CatTipopedido>();
        }
    }
}
