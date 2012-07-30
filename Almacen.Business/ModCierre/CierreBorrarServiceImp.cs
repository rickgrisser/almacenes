using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Dao.ModCierre;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.ModSalida;
using Almacen.Data.Entities;
using NHibernate;
using Spring.Transaction.Interceptor;
using System.Windows.Forms;

namespace Almacen.Business.ModCierre
{
    public class CierreBorrarServiceImp : ICierreBorrarService
    {
        public ICierreDao CierreDao { get; set; }

        [Transaction]
        public IList<Cierre> BorraCierre(ref IList<Cierre> lstCierre)
        {
            foreach (var cierre in lstCierre)
            {
                CierreDao.Delete(cierre);
            }
            return lstCierre;
        }
    }
}
