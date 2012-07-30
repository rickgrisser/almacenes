using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModRequisicion
{
    public interface IFalloDetalleDao : IGenericDao<FalloDetalle, long >
    {
        IList<FalloDetalle> CargaFalloDetalles(long intIdAnexo);

    }
}
