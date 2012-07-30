using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;
namespace Almacen.Data.Dao.Catalogos
{
    public class PedidoDaoImp : GenericDaoImp<Pedido, long>, IPedidoDao
    {
        [Transaction(ReadOnly = true)]
        public Pedido CargaArticulos(long intPedido, int strAnio, int intTipoPedido, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.CargaPedido");
            query.SetParameter("intPedido", intPedido);
            query.SetParameter("strAnio", strAnio);
            query.SetParameter("intTipoPedido", intTipoPedido);
            query.SetParameter("strAlmacen", strAlmacen);

            return query.UniqueResult<Pedido>();
        }
    }
}
