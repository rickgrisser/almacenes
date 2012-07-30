using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModSalida
{
    public interface ISalidaDao : IGenericDao<Salida, int>
    {
        int NumeroSalida(int intAnio, string strAlmacen);
        DateTime CargaUltimaFecha(Entities.Almacen objAlmacen);
        bool SalidaExiste(int intAnio, string strAlmacen, int intNumSalida);
        int IdSalida();
        Salida CargaSalida(int intAnio, string strAlmacen, int intNumeroSalida, int intIdUsuario);
    }
}
