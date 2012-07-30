using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Almacen.Business.ModEntrada;
using Almacen.Data.Entities;
using AlmacenTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Almacen.Test.ModEntrada
{

    [TestFixture]
    public class UnitTestEntrada:AbstractDaoIntegrationTests
    {
        public IEntradaService EntradaService;


        [Test]
        public void TestHistorico()
        {
            var entrada = EntradaService.EntradaDao.CargaEntrada(2012, "P", 626, 370);
            entrada.FechaEntrada = DateTime.Now;
            //EntradaService.GuardaEntrada(ref entrada,true);

        }
    }
}
