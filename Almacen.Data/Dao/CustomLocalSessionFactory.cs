using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Bytecode;
using Spring.Data.NHibernate.Bytecode;
using Spring.Data.NHibernate;

namespace Almacen.Data.Dao
{
    class CustomLocalSessionFactory : LocalSessionFactoryObject
    {
        public override IBytecodeProvider BytecodeProvider
        {

            get
            {

                return new BytecodeProvider(ApplicationContext);
            }
            set { }
        }

    }
}
