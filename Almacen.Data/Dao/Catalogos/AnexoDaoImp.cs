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
    public class AnexoDaoImp : GenericDaoImp<Anexo, long>, IAnexoDao
    {
    }
}
