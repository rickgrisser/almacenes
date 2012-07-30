using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Business.Audit
{
    public class Historico
    {
        /// <summary>
        /// Ids detalles del historico
        /// </summary>
        public List<long> ids = new List<long>();

        /// <summary>
        /// Id padre historico
        /// </summary>
        public long idPadre;
    }
}
