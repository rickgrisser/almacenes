using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Dao.ModSalida;
using Almacen.Data.Entities;
using System.Windows.Forms;
using Almacen.Data.Dao.ModCierre;
using Almacen.Data.Dao.Catalogos;
using NHibernate;

namespace Almacen.Business.ModCierre
{
    public interface ICierreService
    {
        ICierreDao CierreDao { get; set; }
        IArticuloDao ArticuloDao { get; set; }
        ICierrePasoDao CierrePasoDao { get; set; }
        ISalidaDetalleDao SalidaDetalleDao { get; set; }
        ICatPartidaDao CatPartidaDao { get; set; }
        

        IList<CierrePaso> BorraCierrePaso(ref IList<CierrePaso> lstCierrePaso);
    }
}
