using System;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Type;
using Spring.Collections;
using Spring.Context.Support;
using Spring.Transaction.Interceptor;
using System.Linq;


namespace Almacen.Business.Audit
{
    ///<summary>
    ///</summary>
    public class AuditInterceptor : EmptyInterceptor
    {
        private static IAuditService auditService;

        public AuditInterceptor()
        {
            auditService = ContextRegistry.GetContext()["auditService"] as IAuditService;
        }

        ///<summary>
        ///</summary>
        ///<param name="entity"></param>
        ///<param name="id"></param>
        ///<param name="state"></param>
        ///<param name="propertyNames"></param>
        ///<param name="types"></param>
        public override void OnDelete(object entity, object id, object[] state,
            string[] propertyNames, IType[] types)
        {
            
            auditService.ConstruirHistorico(entity, id, propertyNames, state, types, "delete");
            base.OnDelete(entity, id, state, propertyNames, types);
        }


        ///<summary>
        ///</summary>
        ///<param name="entity"></param>
        ///<param name="id"></param>
        ///<param name="currentState"></param>
        ///<param name="previousState"></param>
        ///<param name="propertyNames"></param>
        ///<param name="types"></param>
        ///<returns></returns>
        public override bool OnFlushDirty(object entity, object id,
                            object[] currentState, object[] previousState,
                            string[] propertyNames, IType[] types)
        {
            auditService.ConstruirHistorico(entity, id, propertyNames, previousState, types, "update");
            return base.OnFlushDirty(entity, id, currentState, previousState, propertyNames, types);
        }

    }
}
