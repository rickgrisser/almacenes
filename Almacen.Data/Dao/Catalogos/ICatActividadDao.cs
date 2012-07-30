using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.Catalogos
{
    public interface ICatActividadDao : IGenericDao<CatActividad, int>
    {
        IList<CatActividad> CargaActividad();
    }
}
