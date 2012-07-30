using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModRequisicion
{
    public interface IFalloDao : IGenericDao<Fallo, long>
    {
        IList<Object[]> CargaFallos(int intAnio, string strAlmacen);
    }
}
