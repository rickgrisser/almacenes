using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModCatalogos
{
    public class CatAreaDaoImp : GenericDaoImp<CatArea, short >, ICatAreaDao
    {
        [Transaction(ReadOnly = true)]
        public IList<CatArea> CargaArea(string strTipo, int intCveArea)
        {
            var query = CurrentSession.GetNamedQuery("CatArea.CargaArea");
            query.SetParameter("strTipo", strTipo);
            query.SetParameter("intCveArea", intCveArea);
            return query.List<CatArea>();
        }

        [Transaction(ReadOnly = true)]
        public IList<CatArea> CargaAreas(string strTipo, string  strDesArea)
        {
            var query = CurrentSession.GetNamedQuery("CatArea.CargaAreas");
            query.SetParameter("strTipo", strTipo);
            query.SetParameter("strDesArea", strDesArea);
            return query.List<CatArea>();
        }
    }
}
