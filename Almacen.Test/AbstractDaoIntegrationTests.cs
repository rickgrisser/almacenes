using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Testing.NUnit;

namespace AlmacenTest
{
    public class AbstractDaoIntegrationTests : AbstractTransactionalDbProviderSpringContextTests
    {

        protected override string[] ConfigLocations
        {
            get
            {
                return new string[]
                    {
                        "assembly://Almacen.Data/Almacen.Data.Dao/Dao.xml",
                         "assembly://Almacen.Business/Almacen.Business/Services.xml"
                       
                    };
            }
        }
    }
}