using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.Catalogos
{
    public interface ICatUnidadDao : IGenericDao<CatUnidad, string>
    {
        IList<CatUnidad> CargaUnidades();
    }
}
