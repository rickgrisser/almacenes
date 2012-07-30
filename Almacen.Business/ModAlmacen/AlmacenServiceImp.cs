using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.Seguridad;
using Almacen.Data.Entities;
using NHibernate;
using Spring.Transaction.Interceptor;
using System.Windows.Forms;

namespace Almacen.Business.ModAlmacen
{
    public class AlmacenServiceImp : IAlmacenService
    {
        public IAlmacenDao AlmacenDao { get; set; }

        public void Almacenes(ComboBox combo, int intIdUsuario)
        {
            IList<UsuarioModulo> lstUsuario = AlmacenDao.Almacenes(intIdUsuario);
            var dicc = lstUsuario.ToDictionary(licita => licita, licita => licita.Id.Modulo.Id.Almacen.DesAlmacen);
            Util.Dicc2Combo<UsuarioModulo, string>(dicc, combo);
        }
    }
}
