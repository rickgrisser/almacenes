using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Dao.ModCierre;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.ModSalida;
using Almacen.Data.Entities;
using NHibernate;
using Spring.Transaction.Interceptor;
using System.Windows.Forms;

namespace Almacen.Business.ModCierre
{
    public class CierreServiceImp : ICierreService
    {
        public ICierreDao CierreDao { get; set; }
        public IArticuloDao ArticuloDao { get; set; }
        public ICierrePasoDao CierrePasoDao { get; set; }
        public ISalidaDetalleDao SalidaDetalleDao { get; set; }
        public ICatPartidaDao CatPartidaDao { get; set; }
        
        [Transaction]
        public IList<CierrePaso> BorraCierrePaso(ref IList<CierrePaso> lstCierrePaso)
        {
            //foreach (var cierrePaso in lstCierrePaso)
            //{
            CierrePasoDao.DeleteAll(lstCierrePaso);
            //}
            return lstCierrePaso;
        }
    }
}
