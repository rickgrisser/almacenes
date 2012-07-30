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
    public interface IArticuloCambiarService
    {
        IArticuloDao ArticuloDao { get; set; }
        IArticuloPartidaDao ArticuloPartidaDao { get; set; }
        ICuadroBasicoDao CuadroBasicoDao { get; set; }
        ICatPartidaDao CatPartidaDao { get; set; }

        ArticuloPartida GuardaArticuloPartida(ref CatPartida catPartida, ref ArticuloPartida articuloPartidaActual);
        CuadroBasico GuardaCuadroBasico(ref CuadroBasico cuadroBasico, ref CuadroBasico cuadroBasicoNuevo);
    }
}
