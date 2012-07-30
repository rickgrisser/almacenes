using System;
using Almacen.Data.Dao.Seguridad;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Almacen.Business.Seguridad
{
    public class UsuarioServiceImp : IUsuarioService
    {
        public IUsuarioDao UsuarioDao { get; set; }
    }
}
