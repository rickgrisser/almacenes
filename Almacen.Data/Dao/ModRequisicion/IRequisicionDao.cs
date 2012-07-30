using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao.ModRequisicion
{
    public interface IRequisicionDao : IGenericDao<Requisicion, int>
    {
        int NumeroRequisicion(int intAnio, string strAlmacen);
        int IdRequisicion();
        bool RequisicionExiste(int intAnio, string strAlmacen, int intNumeroRequisicion);

        Requisicion CargaRequisicion(int intAnio, string strAlmacen, int intNumeroRequisicion);
    }
}
