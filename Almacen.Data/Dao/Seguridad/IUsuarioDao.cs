using System.Collections.Generic;
using Almacen.Data.Entities;


namespace Almacen.Data.Dao.Seguridad
{
    public interface IUsuarioDao: IGenericDao<Usuario,int>
    {
        Usuario accessAllow(string rfc, string password);
        IList<UsuarioModulo> modulos(Usuario user);
        IList<Usuario> CargaUsuarioxAlmacen(string strAlmacen);
        
    }
}
