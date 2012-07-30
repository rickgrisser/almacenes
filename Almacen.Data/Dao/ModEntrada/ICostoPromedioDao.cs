using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModEntrada
{
    public interface ICostoPromedioDao : IGenericDao<CostoPromedio, CostoPromedioId>
    {
        decimal CostoPromedio(int intCveArt, string strAlmacen);
    }
}
