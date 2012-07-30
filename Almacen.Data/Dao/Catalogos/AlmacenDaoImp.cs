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
    public class AlmacenDaoImp:GenericDaoImp<Entities.Almacen,string >,IAlmacenDao
    {
        [Transaction(ReadOnly = true)]
        public IList<UsuarioModulo> Almacenes(int intIdUsuario)
        {
            var query = CurrentSession.GetNamedQuery("Almacen.Almacenes");
            query.SetParameter("intIdUsuario", intIdUsuario);
            return query.List<UsuarioModulo>();
        }
    }
}
