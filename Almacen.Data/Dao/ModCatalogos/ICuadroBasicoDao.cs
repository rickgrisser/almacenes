using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModCatalogos
{
    public interface ICuadroBasicoDao : IGenericDao<CuadroBasico, CuadroBasicoId>
    {
        CuadroBasico CargaCuadroBasico(int intCveArt, string strAlmacen);
    }
}
