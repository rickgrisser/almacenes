using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModCatalogos
{
    public class ArticuloPartidaDaoImp : GenericDaoImp<ArticuloPartida, ArticuloPartidaId>, IArticuloPartidaDao
    {
        [Transaction(ReadOnly = true)]
        public ArticuloPartida CargaArticuloPartida(int intCveArt, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Articulo.CargaArticuloPartida");
            query.SetParameter("intCveArt", intCveArt);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<ArticuloPartida>();
        }

        [Transaction(ReadOnly = true)]
        public ArticuloPartida CargaArticuloPartidaCambiarPartida(int intCveArt, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Articulo.CargaArticuloCambioPartida");
            query.SetParameter("intCveArt", intCveArt);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<ArticuloPartida>();
        }
    }
}
