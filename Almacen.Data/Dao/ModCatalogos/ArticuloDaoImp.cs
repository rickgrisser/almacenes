using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModCatalogos
{
    public class ArticuloDaoImp:GenericDaoImp<Articulo,ArticuloId>,IArticuloDao
    {
        [Transaction(ReadOnly = true)]
        public IList<Articulo> CargaArticulosXAlmacen(string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Articulo.CargaArticulosXAlmacen");
            query.SetParameter("strAlmacen", strAlmacen);
            return query.List<Articulo>();
        }

        [Transaction(ReadOnly = true)]
        public int NumeroCveArt(string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Articulo.MaxCveArt");
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<int>();
        }

        [Transaction(ReadOnly = true)]
        public Articulo CargaArticulo(int intCveArt, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Articulo.CargaArticulo");
            query.SetParameter("intCveArt", intCveArt);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<Articulo>();
        }
    }
}
