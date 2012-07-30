using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModCatalogos
{
    public interface IProveedorDao : IGenericDao<Proveedor, int>
    {
        IList<Proveedor> CargaProveedor(int intCveProveedor);
        IList<Proveedor> CargaProveedores(string strNombreFiscal);
    }
}
