using System;
using System.Collections.Generic;
using NHibernate.Criterion;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;
using Almacen.Data;

namespace Almacen.Data.Dao.Seguridad
{
    public class UsuarioDaoImp:GenericDaoImp<Usuario,int>,IUsuarioDao
  
    {
        [Transaction(ReadOnly = true)]
        public Usuario accessAllow(string rfc, string password)
        {
            return CurrentSession.CreateCriteria<Usuario>().
                Add(Restrictions.Eq("Rfc", rfc)).
                Add(Restrictions.Eq("Password", password)).
                Add(Restrictions.Eq("Estatus","A")).
                UniqueResult<Usuario>();
        }

        [Transaction(ReadOnly = true)]
        public IList<UsuarioModulo> modulos(Usuario user)
        {
            return CurrentSession.CreateCriteria<UsuarioModulo>().
               Add(Restrictions.Eq("Id.Usuario", user)).
               List<UsuarioModulo>();

        }

        [Transaction(ReadOnly = true)]
        public IList<Usuario> CargaUsuarioxAlmacen(string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Usuario.xAlmacen");
            query.SetParameter("id_almacen", strAlmacen);
            return query.List<Usuario>();
        }
    }
}
