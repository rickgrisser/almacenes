using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModRequisicion
{
    public interface IRequisicionDetallDao : IGenericDao<RequisicionDetall, long >
    {
        decimal Cantidad(long intIdRequisicion, int intCveArt);
        IList<object[]> RptRequisicionVale(int intNumRequisicion, int intAnio, Entities.Almacen objAlmacen);
    }
}
