using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModRequisicion
{
    public class FalloDetalleDaoImp : GenericDaoImp<FalloDetalle, long >, IFalloDetalleDao
    {
        [Transaction(ReadOnly = true)]
        public IList<FalloDetalle> CargaFalloDetalles(long intIdAnexo)
        {
            var query = CurrentSession.GetNamedQuery("FalloDetalle.CargaFalloDetalles");
            query.SetParameter("intIdAnexo", intIdAnexo);
            return query.List<FalloDetalle>();
        }
    }
}
