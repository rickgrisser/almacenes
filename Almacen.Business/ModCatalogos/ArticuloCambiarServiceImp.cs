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
    public class ArticuloCambiarServiceImp : IArticuloCambiarService
    {
        public IArticuloDao ArticuloDao { get; set; }
        public IArticuloPartidaDao ArticuloPartidaDao { get; set; }
        public ICuadroBasicoDao CuadroBasicoDao { get; set; }
        public ICatPartidaDao CatPartidaDao { get; set; }

        [Transaction]
        public ArticuloPartida GuardaArticuloPartida(ref CatPartida catPartida, ref ArticuloPartida articuloPartidaActual)
        {
            var articuloPartidaId = new ArticuloPartidaId()
            {
                CatPartida = catPartida,
                Articulo = articuloPartidaActual.Id.Articulo,
                Movimiento = articuloPartidaActual.Id.Movimiento + 1
            };
            var articuloPartidaNuevo = new ArticuloPartida(articuloPartidaId)
            {
                FechaInicio = ArticuloPartidaDao.FechaServidor()
            };
            
            ArticuloPartidaDao.Update(articuloPartidaActual);
            ArticuloPartidaDao.Update(articuloPartidaNuevo);

            return articuloPartidaActual;
        }

        [Transaction]
        public CuadroBasico GuardaCuadroBasico(ref CuadroBasico cuadroBasico, ref CuadroBasico cuadroBasicoNuevo)
        {

            CuadroBasicoDao.Update(cuadroBasico);
            CuadroBasicoDao.Update(cuadroBasicoNuevo);

            return cuadroBasico;
        }
    }
}
