using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Dao.ModCatalogos;
using Spring.Transaction.Interceptor;
using System.Windows.Forms;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.ModRequisicion;
using Almacen.Data.Entities;

namespace Almacen.Business.ModRequisicion
{
    public class RequisicionServiceImp : IRequisicionService
    {
        public IRequisicionDetallDao RequisicionDetallDao { get; set; }
        public IRequisicionDao RequisicionDao { get; set; }
        public ICatAreaDao CatAreaDao { get; set; }
        public IArticuloDao ArticuloDao { get; set; }
        public IFalloDao FalloDao { get; set; }
        public IFalloDetalleDao FalloDetalleDao { get; set; }
        public IAnexoDao AnexoDao { get; set; }
        public IPedidoDetalleDao PedidoDetalleDao { get; set; }

        public void CargaArea(ComboBox combo, string strTipo, int intCveArea)
        {
            IList<CatArea> lstUsuario = CatAreaDao.CargaArea(strTipo, intCveArea);
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.DesArea);
            Util.Dicc2Combo<CatArea, string>(dicc, combo);
        }

        public void CargaAreas(ComboBox combo, string strTipo, string strDesArea)
        {
            IList<CatArea> lstUsuario = CatAreaDao.CargaAreas(strTipo, strDesArea);
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.DesArea);
            Util.Dicc2Combo<CatArea, string>(dicc, combo);
        }

        public void CargaFallos(ComboBox combo, int intAnio, string strAlmacen)
        {
            IList<object []> lstUsuario = FalloDao.CargaFallos(intAnio, strAlmacen);
            var dicc = new Dictionary<object, string>();
            foreach (var licita in lstUsuario)
            {
                dicc.Add(licita,licita[0].ToString().Trim());
            }
            Util.Dicc2Combo<object, string>(dicc, combo);
        }

        [Transaction]
        public void GuardaRequisicion(ref Requisicion requisicion, bool blnModificacion)
        {
            //var requisicionesDetalle = requisicion.RequisicionDetall;
            //if (blnModificacion == false)
            //{
            //    requisicion.IdRequisicion = RequisicionDao.IdRequisicion() + 1;
            //}

            //short intRenglon = 1;
            //foreach (var requisicionDetalle in requisicionesDetalle)
            //{
            //    var requisicionDetalleId = new RequisicionDetallId()
            //    {
            //        Requisicion = requisicion,
            //        Renglon = intRenglon++
            //    };
            //    requisicionDetalle.Id = requisicionDetalleId;
            //}
            //RequisicionDao.Merge(requisicion);
            //return requisicion;
            for (var i = 0; i < requisicion.RequisicionDetall.Count; i++)
            {
                var requisicionDetalle = requisicion.RequisicionDetall[i];
                requisicionDetalle.Renglon = (short)(i + 1);
                requisicionDetalle.Requisicion = requisicion;
            }

            requisicion.Modificacion = requisicion.Modificacion == null ? 1 : requisicion.Modificacion++;
            requisicion = RequisicionDao.Merge(requisicion);
        }
     
        [Transaction]
        public IList<FalloDetalle> CargaRequisicion(long intIdAnexo, long intIdRequisicion)
        {
            var bisTmp = FalloDetalleDao.CargaFalloDetalles(intIdAnexo);
            foreach (var falloDetalle in bisTmp)
            {
                falloDetalle.Requisicion = RequisicionDetallDao.Cantidad(intIdRequisicion,falloDetalle.Articulo.Id.CveArt);
            }
            return bisTmp;
        }
    }
}
