using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModCierre
{
    public interface ICierreDao : IGenericDao<Cierre, CierreId>
    {
        bool CierreExiste(string strAlmacen, int intMes, int intAnio);
        Cierre CargaCierrexArticulo(int intCveArt, string strAlmacen, int intMes, int intAnio);
        DateTime CargaUltimaFecha(string strAlmacen);
        bool CierreMesAnteriorExiste(string strAlmacen, int intMes, int intAnio);

        IList<DateTime> CargaFechasCierres(int intAnio, string strAlmacen);
        IList<Cierre> CargaCierreXAlmacen(string strAlmacen, int intMes, int intAnio);

        IList<object[]> RptCierre(int intMes, int intAnio, string strAlmacen, bool bolOpcion);
        IList<object[]> RptCierreXPartida(int intMes, int intAnio, string strAlmacen, string strPartida, bool bolOpcion);
    }
}
