using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Dao.ModCierre;
using Almacen.Data.Entities;
using System.Windows.Forms;
using Almacen.Data.Dao.ModSalida;
using Almacen.Data.Dao.ModEntrada;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.Seguridad;
using NHibernate;

namespace Almacen.Business.ModSalida
{
    public interface ISalidaService
    {
        ISalidaDao SalidaDao {get;set;}
        ISalidaDetalleDao SalidaDetalleDao { get; set; } 
        IUsuarioDao UsuarioDao {get;set;}
        ICatAreaDao CatAreaDao { get; set; }
        IArticuloDao ArticuloDao { get; set; }
        IEntradaDao EntradaDao { get; set; }
        IEntradaDetalleDao EntradaDetalleDao { get; set; }
        ICostoPromedioDao CostoPromedioDao { get; set; }
        ICierreDao CierreDao { get; set; }
        ICatPartidaDao CatPartidaDao { get; set; }

        void UsuariosAlmacen(ComboBox comboBox, string strAlmacen);
        void CargaArea(ComboBox comboBox, string strTipo, int intCveArea);
        void CargaAreas(ComboBox comboBox, string strTipo, string strDesArea);
        void GuardaSalida(ref Salida salida, bool blnModificacion);
        Salida CargaSalida(int intAnio, string strAlmacen, int intNumeroSalida, int intIdUsuario);
        Salida BorraSalida(ref Salida salida);
    }
}
