using System;
using System.Collections;
using System.Collections.ObjectModel;
using Almacen.Business.ModCierre;
using Almacen.Business.ModSalida;
using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.ModCatalogos;
using Almacen.Data.Dao.ModCierre;
using Almacen.Data.Dao.ModEntrada;
using Almacen.Data.Dao.ModSalida;
using Almacen.Data.Entities;
using AlmacenTest;
using NUnit.Framework;
using System.Collections.Generic;

namespace Almacen.Test.ModSalida
{
    [TestFixture]
    public class UnitTestSalida:AbstractDaoIntegrationTests
    {
        public ICierreService CierreService { private get; set; }
        public ISalidaDetalleDao SalidaDetalleDao { private get; set; }
        public IEntradaDetalleDao EntradaDetalleDao { private get; set; }
        public ICierrePasoDao CierrePasoDao { private get; set; }
        public ICierreDao CierreDao { private get; set; }
        public IArticuloDao ArticuloDao { private get; set; }
        public IAlmacenDao AlmacenDao { private get; set; }


        [Test]
        public void GuardaResguardoEntregayDetalle()
        {
            var objAlmacen = new Data.Entities.Almacen() {IdAlmacen = "P"};
            String strDateTo = "2012-01-04";
            DateTime dateTo = DateTime.Parse(strDateTo);

            String strDateTo2 = "2012-01-04";
            DateTime dateTo2 = DateTime.Parse(strDateTo2);

            //var resguardo = EntradaDetalleDao.RptEntradaDetallado(dateTo, dateTo2,objAlmacen);
            //Assert.AreEqual(4, resguardo.Count);

            //------
            //var ent=EntradaDetalleDao.RptEntradaVale(1, 2011, "F");
            //Assert.AreEqual(6,ent[0].ToString());
        }


        [Test]
        public void RptCierre()
        {

            String strDateTo = "2011-11-01";
            DateTime dateTo = DateTime.Parse(strDateTo);

            String strDateTo2 = "2011-11-30";
            DateTime dateTo2 = DateTime.Parse(strDateTo2);
            var objAlmacen = AlmacenDao.Get("F");
            var resguardo = EntradaDetalleDao.RptEntradaPartida(dateTo, dateTo2, objAlmacen);
            Assert.AreEqual("5", resguardo);
        }


        [Test]
        public void Kardex()
        {
            String strDateTo = "2011-01-01";
            DateTime dateTo = DateTime.Parse(strDateTo);

            String strDateTo2 = "2011-02-28";
            DateTime dateTo2 = DateTime.Parse(strDateTo2);
            var ad = EntradaDetalleDao.RptKardexArticulos(dateTo, dateTo2,39,39,"F");
            Assert.AreEqual(10,ad.Count);
        }
        [TearDown]
        public void Finalizar()
        {
            //base.SetComplete();
        }




    }
}
