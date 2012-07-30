using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;
namespace Almacen.Data.Dao.ModEntrada
{
    public class EntradaDetalleDaoImp : GenericDaoImp<EntradaDetalle, long>, IEntradaDetalleDao
    {
        [Transaction(ReadOnly = true)]
        public decimal SumCantEntro(long intPedido, int intArticulo)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.CantEntro");
            query.SetParameter("intPedido", intPedido);
            query.SetParameter("intArticulo", intArticulo);
            return query.UniqueResult<decimal>();
        }

        [Transaction(ReadOnly = true)]
        public decimal CantidadTotal(int intCveArt, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.CantidadTotal");
            query.SetParameter("intCveArt", intCveArt);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<decimal>();
        }

        [Transaction(ReadOnly = true)]
        public decimal SumCantArt(long intIdEntrada, int intCveArt)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.CantArt");
            query.SetParameter("intIdEntrada", intIdEntrada);
            query.SetParameter("intCveArt", intCveArt);
            return query.UniqueResult<decimal>();
        }

        [Transaction(ReadOnly = true)]
        public bool MovimientosPosteriores(string strAlmacen, Collection<int> strArticulos, DateTime strFecha)
        {
            var result = false;
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.MovimientosPosteriores");
            query.SetParameterList("strArticulos", strArticulos.ToList());
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("strFecha", strFecha);
            if (query.UniqueResult<Int64>() > 0)
            {
                result = true;
            }
            return result;
        }

        [Transaction(ReadOnly = true)]
        public decimal ExistenciaTotal(int intCveArt, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.ExistenciaTotal");
            query.SetParameter("intCveArt", intCveArt);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<decimal>();
        }

        [Transaction(ReadOnly = true)]
        public EntradaDetalle CargaDetalleXFechaExistencia(int intCveArt, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.CargaDetalleXFechaExistencia");
            query.SetParameter("intCveArt", intCveArt);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetMaxResults(1);
            return query.UniqueResult<EntradaDetalle>();
        }

        [Transaction(ReadOnly = true)]
        public EntradaDetalle CargaDetalleXFechaExistencia0(int intCveArt, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.CargaDetalleXFechaExistencia0");
            query.SetParameter("intCveArt", intCveArt);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetMaxResults(1);
            return query.UniqueResult<EntradaDetalle>();
        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptEntradaVale(int intNumEntrada,int intAnio, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.RptEntradaVale");
            query.SetParameter("intNumEntrada", intNumEntrada);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptEntradaValeSinPedido(int intNumEntrada, int intAnio, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.RptEntradaValeSinPedido");
            query.SetParameter("intNumEntrada", intNumEntrada);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptEntradaPartida(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.RptEntradaPartida");
            query.SetParameter("datFechaIni", datFechaIni);
            query.SetParameter("datFechaFin", datFechaFin);
            query.SetParameter("objAlmacen", objAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptEntradaIFAI(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen, CatPartida objCatPartida)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.RptEntradaIFAI");
            query.SetParameter("datFechaIni", datFechaIni);
            query.SetParameter("datFechaFin", datFechaFin);
            query.SetParameter("objAlmacen", objAlmacen);
            query.SetParameter("objCatPartida", objCatPartida);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptKardexArticulos(DateTime dtFechaIni, DateTime dtFechaFin, int intCveArtIni, int intCveArtFin,
            string strIdAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.KardexArticulos");
            query.SetParameter("dtFechaIni", dtFechaIni);
            query.SetParameter("dtFechaFin", dtFechaFin);
            query.SetParameter("intCveArtIni", intCveArtIni);
            query.SetParameter("intCveArtFin", intCveArtFin);
            query.SetParameter("strIdAlmacen", strIdAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptKardexPartida(DateTime dtFechaIni, DateTime dtFechaFin, string strPartida, string strIdAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.KardexPartida");
            query.SetParameter("dtFechaIni", dtFechaIni);
            query.SetParameter("dtFechaFin", dtFechaFin);
            query.SetParameter("strIdAlmacen", strIdAlmacen);
            query.SetParameter("strPartida", strPartida);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptKardexFechas(DateTime dtFechaIni, DateTime dtFechaFin, string strIdAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.KardexFechas");
            query.SetParameter("dtFechaIni", dtFechaIni);
            query.SetParameter("dtFechaFin", dtFechaFin);
            query.SetParameter("strIdAlmacen", strIdAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptKardexFull(DateTime dtFechaIni, DateTime dtFechaFin, int intCveArtIni, int intCveArtFin,
                        string strPartida, string strIdAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.KardexFull");
            query.SetParameter("dtFechaIni", dtFechaIni);
            query.SetParameter("dtFechaFin", dtFechaFin);
            query.SetParameter("intCveArtIni", intCveArtIni);
            query.SetParameter("intCveArtFin", intCveArtFin);
            query.SetParameter("strPartida", strPartida);
            query.SetParameter("strIdAlmacen", strIdAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptEntradaFolioPartida(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.RptEntradaFolioPartida");
            query.SetParameter("datFechaIni", datFechaIni);
            query.SetParameter("datFechaFin", datFechaFin);
            query.SetParameter("objAlmacen", objAlmacen);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptEntradaDetallado(Entities.Almacen objAlmacen, string strEntradaFecha,
                    string strEntradaFolio, string strSituacion, string strTipoPedido, CatTipopedido objCatTipopedido,
                    string strPedidoFecha, string strPedidoFolio)
        {
            var strSql="Select ed.Entrada.FechaEntrada, ed.Entrada.NumeroEntrada, ed.Entrada.NumeroFactura,  " + 
                    "ed.Entrada.Pedido.CatTipopedido.DesTipoped, ed.Entrada.Pedido.FechaPedido,  " + 
                    "ed.Entrada.Pedido.NumeroPedido, ed.Articulo.Id.CveArt, ed.Articulo.DesArticulo, " + 
                    "ed.Cantidad, " +
                    "pd.Marca, pd.PrecioUnitario, " +
                    "ed.FechaCaducidad, ed.NoLote, " + 
                    "pd.Pedido.ImporteDescuento, pd.Pedido.Iva.Id.Porcentaje, " + 
                    "ed.Entrada.EstadoEntrada " +
                "from EntradaDetalle ed, PedidoDetalle pd " +
                "where " + strEntradaFecha +
                            strEntradaFolio +
                            strSituacion + 
                            strTipoPedido +
                            strPedidoFecha +
                            strPedidoFolio +
                "ed.Entrada.Almacen=:objAlmacen " +
                    "and (pd.Pedido.IdPedido=ed.Entrada.Pedido.IdPedido and " +
                         "pd.Articulo.Id.CveArt=ed.Articulo.Id.CveArt) " +
                "order by 2,7";
            var query = CurrentSession.CreateQuery(strSql);
            query.SetParameter("objAlmacen", objAlmacen);
            if(strTipoPedido.Length>0)
            {query.SetParameter("objCatTipopedido", objCatTipopedido);}
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptEntradaProveedor(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen,
                        Proveedor objProveedor)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.RptEntradaProveedor");
            query.SetParameter("datFechaIni", datFechaIni);
            query.SetParameter("datFechaFin", datFechaFin);
            query.SetParameter("objAlmacen", objAlmacen);
            query.SetParameter("objProveedor", objProveedor);
            return query.List<object[]>();

        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptEntradaPedido(Entities.Almacen objAlmacen, int intNumeroPedido, int intAnio,
                    CatTipopedido objCatTipopedido)
        {
            var query = CurrentSession.GetNamedQuery("EntradaDetalle.RptEntradaPedido");
            query.SetParameter("intNumeroPedido", intNumeroPedido);
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("objAlmacen", objAlmacen);
            query.SetParameter("objCatTipopedido", objCatTipopedido);
            return query.List<object[]>();

        }
    }
}
