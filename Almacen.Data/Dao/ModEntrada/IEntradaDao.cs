using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModEntrada
{
    public interface IEntradaDao : IGenericDao<Entrada, int>
    {
        int NumeroEntrada(int intAnio, string strAlmacen);
        long IdEntrada();
        bool EntradaExiste(int intAnio, string strAlmacen, int numeroEntrada);
        Entrada CargaEntrada(int intAnio, string strAlmacen, int numeroEntrada, int intIdUsuario);
        DateTime CargaUltimaFecha(Entities.Almacen objAlmacen);
        Entrada CargaSoloEntrada(int intAnio, string strAlmacen, int numeroEntrada);

        IList<object[]> RptEntradaFolio(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen);
    }
}
