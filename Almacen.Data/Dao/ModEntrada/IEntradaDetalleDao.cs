using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
namespace Almacen.Data.Dao.ModEntrada
{
    public interface IEntradaDetalleDao : IGenericDao<EntradaDetalle, long>
    {
        decimal SumCantEntro(long intPedido, int intArticulo);
        decimal CantidadTotal(int intCveArt, string strAlmacen);
        decimal SumCantArt(long intIdEntrada, int intCveArt);
        bool MovimientosPosteriores(string strAlmacen, Collection<int> strArticulos, DateTime strFecha);
        decimal ExistenciaTotal(int intCveArt, string strAlmacen);
        EntradaDetalle CargaDetalleXFechaExistencia(int intCveArt, string strAlmacen);
        EntradaDetalle CargaDetalleXFechaExistencia0(int intCveArt, string strAlmacen);
        IList<object[]> RptEntradaVale(int intNumEntrada, int intAnio, string strAlmacen);
        IList<object[]> RptEntradaValeSinPedido(int intNumEntrada, int intAnio, string strAlmacen);
        IList<object[]> RptEntradaPartida(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen);
        IList<object[]> RptEntradaIFAI(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen, 
            CatPartida objCatPartida);

        IList<object[]> RptKardexArticulos(DateTime dtFechaIni, DateTime dtFechaFin, int intCveArtIni, int intCveArtFin,
            string strIdAlmacen);
        IList<object[]> RptKardexPartida(DateTime dtFechaIni, DateTime dtFechaFin, string strPartida, string strIdAlmacen);
        IList<object[]> RptKardexFechas(DateTime dtFechaIni, DateTime dtFechaFin, string strIdAlmacen);
        IList<object[]> RptKardexFull(DateTime dtFechaIni, DateTime dtFechaFin, int intCveArtIni, int intCveArtFin,
            string strPartida, string strIdAlmacen);

        IList<object[]> RptEntradaFolioPartida(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen);
        IList<object[]> RptEntradaDetallado(Entities.Almacen objAlmacen, string strEntradaFecha,
                    string strEntradaFolio, string strSituacion, string strTipoPedido, CatTipopedido objCatTipopedido,
                    string strPedidoFecha, string strPedidoFolio);
        IList<object[]> RptEntradaProveedor(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen,
                    Proveedor objProveedor);
        IList<object[]> RptEntradaPedido(Entities.Almacen objAlmacen, int intNumeroPedido, int intAnio,
                CatTipopedido objCatTipopedido);
    }
}
