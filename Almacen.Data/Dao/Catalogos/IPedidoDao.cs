using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.Catalogos
{
    public interface IPedidoDao : IGenericDao<Pedido, long>
    {
        Pedido CargaArticulos(long intPedido, int strAnio, int intTipoPedido, string strAlmacen);
    }
}
