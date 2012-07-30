using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Entities;
using System.Windows.Forms;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Dao.Seguridad;
using NHibernate;

namespace Almacen.Business.ModCatalogos
{
    public interface IArticuloService
    {
        IArticuloDao ArticuloDao { get; set; }
        IArticuloFarmaciaDao ArticuloFarmaciaDao { get; set; }
        IArticuloPartidaDao ArticuloPartidaDao { get; set; }
        ICuadroBasicoDao CuadroBasicoDao { get; set; }
        ICatUnidadDao CatUnidadDao { get; set; }
        IViaAdministracionDao ViaAdministracionDao { get; set; }
        ITipoMedicamentoDao TipoMedicamentoDao { get; set; }
        ICatPartidaDao CatPartidaDao { get; set; }

        void Unidades(ComboBox combo);
        void ViaAdministracion(ComboBox combo);
        void TipoMedicamento(ComboBox combo);
        Articulo GuardaArticulo(ref Articulo articulo, bool blnModificacion, Data.Entities.Almacen almacen);
        
    }
}
