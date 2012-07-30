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
    public class CatPartidaDaoImp : GenericDaoImp<CatPartida, string >, ICatPartidaDao
    {
        [Transaction(ReadOnly = true)]
        public CatPartida CargaPartida(string strPartida)
        {
            var query = CurrentSession.GetNamedQuery("CatPartida.CargaPartida");
            query.SetParameter("strPartida", strPartida);
            return query.UniqueResult <CatPartida>();
        }
    }
}
