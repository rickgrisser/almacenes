using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Entities;
using System.Windows.Forms;
using Almacen.Data.Dao.ModEntrada;
using Almacen.Data.Dao.ModSalida;
using Almacen.Data.Dao.ModCierre;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.Seguridad;
using NHibernate;

namespace Almacen.Business.ModEntrada
{
    public interface IEntradaService
    {
        IEntradaDao EntradaDao{get;set;}
        IEntradaDetalleDao EntradaDetalleDao{get;set;}
        IUsuarioDao UsuarioDao{get;set;}
        IPedidoDao PedidoDao{get;set;}
        ICostoPromedioDao CostoPromedioDao{get;set;}
        ISalidaDao SalidaDao { get; set; }
        ISalidaDetalleDao SalidaDetalleDao{get;set;}
        ICierreDao CierreDao { get; set; }
        ICierrePasoDao CierrePasoDao { get; set; }
        IArticuloDao ArticuloDao { get; set; }
        ICatActividadDao CatActividadDao { get; set; }
        ICatPresupuestoDao CatPresupuestoDao { get; set; }
        ICatPartidaDao CatPartidaDao { get; set; }
        ICatTipopedidoDao CatTipopedidoDao { get; set; }
        IProveedorDao ProveedorDao { get; set; }

        void UsuariosAlmacen(ComboBox comboBox, string strAlmacen);
        Pedido CargaPedido(long intPedido, int strAnio, int intTipoPedido, string strAlmacen, long intIdEntrada, bool blnModificacion);
        void GuardaEntrada(ref Entrada entrada, bool blnModificacion);
        IList<CierrePaso> BorraCierrePaso(ref IList<CierrePaso> lstCierrePaso);
        void CatActividad(ComboBox comboBox);
        void CatPresupuesto(ComboBox comboBox);

        void CatTipoPedidos(ComboBox comboBox);
        void SituacionCombo(ComboBox comboBox);

        void CargaProveedor(ComboBox comboBox, int intCveProveedor);
        void CargaProveedores(ComboBox comboBox, string strNombreFiscal);
    }
}
