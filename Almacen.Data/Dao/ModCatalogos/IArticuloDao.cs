using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModCatalogos
{
    public interface IArticuloDao:IGenericDao<Articulo,ArticuloId >
    {
        IList<Articulo> CargaArticulosXAlmacen(string strAlmacen);
        int NumeroCveArt(string strAlmacen);
       Articulo CargaArticulo(int intCveArt, string strAlmacen);
    }
}
