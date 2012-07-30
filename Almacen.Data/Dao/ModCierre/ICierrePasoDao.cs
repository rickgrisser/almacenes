using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModCierre
{
    public interface ICierrePasoDao : IGenericDao<CierrePaso, CierrePasoId>
    {
        IList<CierrePaso> CargaCierrePaso(string strAlmacen);
        //IList<EntradaDetalle> CargaEntradas(int intCveArt, DateTime dtFechaIni, DateTime dtFechaFin, string strAlmacen);
        //IList<SalidaDetalle> CargaSalidas(int intCveArt, DateTime dtFechaIni, DateTime dtFechaFin, string strAlmacen);

        IList<object[]> CargaEntradas(int intCveArt, DateTime dtFechaIni, DateTime dtFechaFin, string strAlmacen);
        IList<object[]> CargaSalidas(int intCveArt, DateTime dtFechaIni, DateTime dtFechaFin, string strAlmacen);
        
    }
}
