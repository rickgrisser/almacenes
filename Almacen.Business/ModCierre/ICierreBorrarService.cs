using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Almacen.Data.Dao.ModSalida;
using Almacen.Data.Entities;
using System.Windows.Forms;
using Almacen.Data.Dao.ModCierre;
using Almacen.Data.Dao.Catalogos;
using NHibernate;

namespace Almacen.Business.ModCierre
{
    public interface ICierreBorrarService
    {
        ICierreDao CierreDao { get; set; }

        IList<Cierre> BorraCierre(ref IList<Cierre> lstCierre);
        
    }
}
