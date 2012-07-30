using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.Catalogos
{
    public interface IPedidoDetalleDao : IGenericDao<PedidoDetalle, long>
    {
        IList<object[]> RptPedidosGenerados(int intNumRequisicion, int intAnio, Entities.Almacen objAlmacen);
        
    }
}
