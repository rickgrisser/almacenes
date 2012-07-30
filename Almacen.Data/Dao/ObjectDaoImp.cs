using System;
using System.Collections.Generic;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao
{
    public class ObjectDaoImp:GenericDaoImp<object,long>,IObjectDao
    {
        [Transaction(ReadOnly = true)]
        public long GetIdHistorico(String nombreTablaPadreHist, long idPadre)
        {
           
                var hql = @"select h.Id from " + nombreTablaPadreHist +
                            " h where IdExterno=:idPadre and Modificacion = (select max(Modificacion) from " 
                             + nombreTablaPadreHist + " where IdExterno =:idPadre)";

                var query = CurrentSession.CreateQuery(hql);
                query.SetParameter("idPadre", idPadre);
                
                return query.UniqueResult<long>();
        
        }

         [Transaction]
        public void UpdateHistoricaHija(string nombreTablaHijaHist, List<long> listaids, long idHistPadre)
        {
            //CurrentSession.Flush();
            foreach (var id in listaids)
            {
                var hql = @"update  " + nombreTablaHijaHist +
                          " set IdHist = :idPadre where Id=:id)";

                var query = CurrentSession.CreateQuery(hql);
                query.SetParameter("idPadre", idHistPadre);
                query.SetParameter("id", id);
                query.ExecuteUpdate();
               
            }
        }
    }
}
