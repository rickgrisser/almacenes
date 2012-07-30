using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModSalida
{
    public interface ISalidaDetalleDao : IGenericDao<SalidaDetalle, long>
    {
        bool SalidaExiste(long intIdEntrada);
        IList<SalidaDetalle> CargaSalidaDetalles(long intIdSalida, int intCveArt);
        bool MovimientosPosteriores(string strAlmacen, Collection<int> strArticulos, DateTime strFecha);
        IList<object[]> CargaSumSurtida(long intIdSalida);
        IList<object[]> RptSalidaVale(long intNumSalida, int intAnio, string strAlmacen);
        IList<object[]> RptSalidaPartida(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen);
        IList<object[]> RptSalidaFolioPartida(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen);
        IList<object[]> RptSalidaDetallado(Entities.Almacen objAlmacen, string strSalidaFecha,
                    string strSalidaFolio, string strSituacion, string strCatArea, CatArea objCatArea);
        IList<object[]> RptSalidaFolio(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen);
        IList<object[]> RptSalidaArea(Entities.Almacen objAlmacen, DateTime datFechaIni, DateTime datFechaFin,
                    string strArea, CatArea objCatArea, CatPartida objCatPartida);
    }
}
