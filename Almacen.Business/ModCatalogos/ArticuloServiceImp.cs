using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Dao.Seguridad;
using Almacen.Data.Entities;
using NHibernate;
using Spring.Transaction.Interceptor;
using System.Windows.Forms;

namespace Almacen.Business.ModCatalogos
{
    public class ArticuloServiceImp : IArticuloService
    {
        public IArticuloDao ArticuloDao { get; set; }
        public IArticuloFarmaciaDao ArticuloFarmaciaDao { get; set; }
        public IArticuloPartidaDao ArticuloPartidaDao { get; set; }
        public ICuadroBasicoDao CuadroBasicoDao { get; set; }
        public ICatUnidadDao CatUnidadDao { get; set; }
        public IViaAdministracionDao ViaAdministracionDao { get; set; }
        public ITipoMedicamentoDao TipoMedicamentoDao { get; set; }
        public ICatPartidaDao CatPartidaDao { get; set; }

        public void Unidades(ComboBox combo)
        {
            IList<CatUnidad> lstUsuario = CatUnidadDao.CargaUnidades();
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.Unidad);
            Util.Dicc2Combo<CatUnidad, string>(dicc, combo);
        }

        public void ViaAdministracion(ComboBox combo)
        {
            IList<ViaAdministracion> lstUsuario = ViaAdministracionDao.Carga();
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.DesAdministracion);
            Util.Dicc2Combo<ViaAdministracion, string>(dicc, combo);
        }

        public void TipoMedicamento(ComboBox combo)
        {
            IList<TipoMedicamento> lstUsuario = TipoMedicamentoDao.CargaTipos();
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.DesMedicamento);
            Util.Dicc2Combo<TipoMedicamento, string>(dicc, combo);
        }

        [Transaction]
        public Articulo GuardaArticulo(ref Articulo articulo, bool blnModificacion, Data.Entities.Almacen almacen)
        {
            if (blnModificacion == false)
            {
                var objArticuloId = new ArticuloId()
                    {
                        CveArt = ArticuloDao.NumeroCveArt(almacen.IdAlmacen)+1,
                        Almacen = almacen
                    };
                articulo.Id = objArticuloId;

                foreach (var articuloPartida in articulo.ArticuloPartida)
                {
                    articuloPartida.Id.Articulo = articulo;
                }
            }

            if (articulo.ArticuloFarmacia != null)
            {
                var objArticuloFarmaciaId = new ArticuloFarmaciaId() { Articulo = articulo };
                foreach (var objArticuloFarmacia in articulo.ArticuloFarmacia)
                {
                    objArticuloFarmacia.Id = objArticuloFarmaciaId;
                }
            }

            if (articulo.CuadroBasico!=null)
            {
                foreach (var cuadroBasico in articulo.CuadroBasico)
                {
                    cuadroBasico.Id.Articulo = articulo;
                }
            }
            ArticuloDao.Update(articulo);
            return articulo;
        }

    }
}
