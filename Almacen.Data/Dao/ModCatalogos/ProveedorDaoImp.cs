using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModCatalogos
{
    public class ProveedorDaoImp : GenericDaoImp<Proveedor, int>, IProveedorDao
    {
        [Transaction(ReadOnly = true)]
        public IList<Proveedor> CargaProveedor(int intCveProveedor)
        {
            var query = CurrentSession.GetNamedQuery("Proveedor.CargaProveedor");
            query.SetParameter("intCveProveedor", intCveProveedor);
            return query.List<Proveedor>();
        }

        [Transaction(ReadOnly = true)]
        public IList<Proveedor> CargaProveedores(string strNombreFiscal)
        {
            var query = CurrentSession.GetNamedQuery("Proveedor.CargaProveedores");
            query.SetParameter("strNombreFiscal", strNombreFiscal);
            return query.List<Proveedor>();
        }
    }
}
