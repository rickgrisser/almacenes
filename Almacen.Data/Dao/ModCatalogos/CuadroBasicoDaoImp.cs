using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModCatalogos
{
    public class CuadroBasicoDaoImp : GenericDaoImp<CuadroBasico, CuadroBasicoId>, ICuadroBasicoDao
    {
        [Transaction(ReadOnly = true)]
        public CuadroBasico CargaCuadroBasico(int intCveArt, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Articulo.CargaArticuloCambioCuadro");
            query.SetParameter("intCveArt", intCveArt);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<CuadroBasico>();
        }
    }
}
