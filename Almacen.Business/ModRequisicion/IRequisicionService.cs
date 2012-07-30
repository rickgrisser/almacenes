using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Dao.ModRequisicion;

using Almacen.Data.Entities;

namespace Almacen.Business.ModRequisicion
{
    public interface IRequisicionService
    {
        IRequisicionDao RequisicionDao { get; set; }
        IRequisicionDetallDao RequisicionDetallDao { get; set; }
        ICatAreaDao CatAreaDao { get; set; }
        IArticuloDao ArticuloDao { get; set; }
        IFalloDao FalloDao { get; set; }
        IFalloDetalleDao FalloDetalleDao { get; set; }
        IAnexoDao AnexoDao { get; set; }
        IPedidoDetalleDao PedidoDetalleDao { get; set; }

        void CargaArea(ComboBox comboBox, string strTipo, int intCveArea);
        void CargaAreas(ComboBox comboBox, string strTipo, string strDesArea);
        void CargaFallos(ComboBox comboBox, int intAnio, string strAlmacen);
        void GuardaRequisicion(ref Requisicion requisicion, bool blnModificacion);
        IList<FalloDetalle> CargaRequisicion(long intIdAnexo, long intIdRequisicion);

    }
}

