using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;
namespace Almacen.Data.Dao.Catalogos
{
    public class ViaAdministracionDaoImp : GenericDaoImp<ViaAdministracion, int>, IViaAdministracionDao
    {
        [Transaction(ReadOnly = true)]
        public IList<ViaAdministracion> Carga()
        {
            var query = CurrentSession.GetNamedQuery("ViaAdministracion.Carga");
            return query.List<ViaAdministracion>();
        }
    }
}
