using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Dao.ModEntrada;
using Almacen.Data.Dao.ModSalida;
using Almacen.Data.Dao.ModCierre;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.Seguridad;
using Almacen.Data.Entities;
using NHibernate;
using Spring.Transaction.Interceptor;
using System.Windows.Forms;

namespace Almacen.Business.ModEntrada
{
    public class EntradaServiceImp : IEntradaService
    {
        public IEntradaDao EntradaDao { get; set; }
        public IEntradaDetalleDao EntradaDetalleDao { get; set; }
        public IUsuarioDao UsuarioDao { get; set; }
        public IPedidoDao PedidoDao { get; set; }
        public ICostoPromedioDao CostoPromedioDao { get; set; }
        public ISalidaDetalleDao SalidaDetalleDao { get; set; }
        public ISalidaDao SalidaDao { get; set; }
        public ICierreDao CierreDao { get; set; }
        public ICierrePasoDao CierrePasoDao { get; set; }
        public IArticuloDao ArticuloDao { get; set; }
        public ICatActividadDao CatActividadDao { get; set; }
        public ICatPresupuestoDao CatPresupuestoDao { get; set; }
        public ICatPartidaDao CatPartidaDao { get; set; }
        public ICatTipopedidoDao CatTipopedidoDao { get; set; }
        public IProveedorDao ProveedorDao { get; set; }

        public void UsuariosAlmacen(ComboBox combo, string strAlmacen)
        {
            IList<Usuario> lstUsuario = UsuarioDao.CargaUsuarioxAlmacen(strAlmacen);
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.Nombre);
            Util.Dicc2Combo<Usuario, string>(dicc, combo);
        }
        
        [Transaction(ReadOnly = true)]
        public Pedido CargaPedido(long intPedido, int strAnio, int intTipoPedido, string strAlmacen, long intIdEntrada, bool blnModificacion)
        {
            var cargaPedido = PedidoDao.CargaArticulos(intPedido, strAnio, intTipoPedido, strAlmacen);

            if (cargaPedido != null)
            {
                var pedidoDetalles = cargaPedido.PedidoDetalle;
                foreach (var articuloDetalleConsulta in pedidoDetalles)
                {
                    articuloDetalleConsulta.Descripcion = articuloDetalleConsulta.Articulo.DesArticulo;
                    articuloDetalleConsulta.Clave = articuloDetalleConsulta.Articulo.Id.CveArt;
                    articuloDetalleConsulta.XEntregar = (decimal) articuloDetalleConsulta.Cantidad -
                                                        EntradaDetalleDao.SumCantEntro(
                                                            articuloDetalleConsulta.Pedido.IdPedido,
                                                            articuloDetalleConsulta.Articulo.Id.CveArt);
                    if (blnModificacion)
                    {
                        articuloDetalleConsulta.Recibida = EntradaDetalleDao.SumCantArt(
                            intIdEntrada, articuloDetalleConsulta.Articulo.Id.CveArt);
                        articuloDetalleConsulta.XEntregar = articuloDetalleConsulta.XEntregar +
                                                            articuloDetalleConsulta.Recibida;
                    }

                    articuloDetalleConsulta.CantidadTotal = EntradaDetalleDao.CantidadTotal(
                        articuloDetalleConsulta.Articulo.Id.CveArt, strAlmacen);
                    articuloDetalleConsulta.CostoPromedio = CostoPromedioDao.CostoPromedio(
                        articuloDetalleConsulta.Articulo.Id.CveArt, strAlmacen);
                }
            
            }
            return cargaPedido;
        }

        [Transaction]
        public void GuardaEntrada(ref Entrada entrada, bool blnModificacion)
        {   
            for (var i = 0; i < entrada.EntradaDetalle.Count; i++)
            {
                var entradaDetalle = entrada.EntradaDetalle[i];
                entradaDetalle.RenglonEntrada = (short)(i+1);
                entradaDetalle.Entrada = entrada;
            }
            entrada.FechaModificacion = EntradaDao.FechaServidor();
            entrada.Modificacion=entrada.Modificacion==null?1:entrada.Modificacion+1;
            entrada = EntradaDao.Merge(entrada);
        }

        [Transaction]
        public IList<CierrePaso> BorraCierrePaso(ref IList<CierrePaso> lstCierrePaso)
        {
            foreach (var cierrePaso in lstCierrePaso)
            {
                CierrePasoDao.Delete(cierrePaso);
            }
            return lstCierrePaso;
        }

        public void CatActividad(ComboBox combo)
        {
            IList<CatActividad> lst = CatActividadDao.CargaActividad();
            var dicc = lst.ToDictionary(licita => licita, licita => licita.DesActividad);
            Util.Dicc2Combo<CatActividad, string>(dicc, combo);
        }

        public void CatPresupuesto(ComboBox combo)
        {
            IList<CatPresupuesto> lst = CatPresupuestoDao.CargaPresupuesto();
            var dicc = lst.ToDictionary(licita => licita, licita => licita.DesPresupuesto);
            Util.Dicc2Combo<CatPresupuesto, string>(dicc, combo);
        }

        public void CatTipoPedidos(ComboBox combo)
        {
            IList<CatTipopedido> lst = CatTipopedidoDao.CargaTipoPedidos();
            var dicc = lst.ToDictionary(licita => licita, licita => licita.DesTipoped);
            Util.Dicc2Combo<CatTipopedido, string>(dicc, combo);
        }

        public void SituacionCombo(ComboBox combo)
        {
            var situacion = new Dictionary<string, string>
                                 {
                                     {"A", "ACTIVOS"},
                                     {"C", "CANCELADOS"},
                                     {"T", "TODOS"}
                                 };
            Util.Dicc2Combo<string, string>(situacion, combo);
        }

        public void CargaProveedor(ComboBox combo, int intCveProveedor)
        {
            IList<Proveedor> lstProveedor = ProveedorDao.CargaProveedor(intCveProveedor);
            var dicc = lstProveedor.ToDictionary(licita => licita, licita => licita.NombreFiscal);
            Util.Dicc2Combo<Proveedor, string>(dicc, combo);
        }

        public void CargaProveedores(ComboBox combo, string strNombreFiscal)
        {
            IList<Proveedor> lstProveedor = ProveedorDao.CargaProveedores(strNombreFiscal);
            var dicc = lstProveedor.ToDictionary(licita => licita, licita => licita.NombreFiscal);
            Util.Dicc2Combo<Proveedor, string>(dicc, combo);
        }
    }
}
