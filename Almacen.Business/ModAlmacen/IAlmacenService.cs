using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Almacen.Data.Entities;
using System.Windows.Forms;

using Almacen.Data.Dao.Catalogos;
using Almacen.Data.Dao.Seguridad;
using NHibernate;

namespace Almacen.Business.ModAlmacen
{
    public interface IAlmacenService
    {
        IAlmacenDao AlmacenDao
        {
            get;
            set;
        }

        void Almacenes(ComboBox combo, int intIdUsuario);
    }
}
