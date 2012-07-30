using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModCatalogos
{
    public interface ICatAreaDao : IGenericDao<CatArea, short>
    {
        IList<CatArea> CargaArea(string strTipo, int intCveArea);
        IList<CatArea> CargaAreas(string strTipo, string strDesArea);
    }
}
