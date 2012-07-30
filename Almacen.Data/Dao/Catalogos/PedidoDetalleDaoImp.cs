using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;
namespace Almacen.Data.Dao.Catalogos
{
    public class PedidoDetalleDaoImp : GenericDaoImp<PedidoDetalle, long>, IPedidoDetalleDao
    {

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptPedidosGenerados(int intNumRequisicion, int intAnio, Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("PedidoDetalle.RptPedidosGenerados");
            query.SetParameter("intNumRequisicion", intNumRequisicion);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("objAlmacen", objAlmacen);
            return query.List<object[]>();

        }

        
    }

    
}
