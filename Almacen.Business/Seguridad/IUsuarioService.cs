using Almacen.Data.Dao.Seguridad;
using Almacen.Data.Entities;

namespace Almacen.Business.Seguridad
{
    public interface IUsuarioService
    {
        IUsuarioDao UsuarioDao { get; set; }
    }
}
