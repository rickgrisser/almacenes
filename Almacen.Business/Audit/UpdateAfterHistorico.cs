using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Spring.Aop;
using Spring.Context.Support;

namespace Almacen.Business.Audit
{
    public class UpdateAfterHistorico : IAfterReturningAdvice
    {   

        ///<summary>
        ///</summary>
        ///<param name="returnValue"></param>
        ///<param name="method"></param>
        ///<param name="args"></param>
        ///<param name="target"></param>
        public void AfterReturning(object returnValue, MethodInfo method, object[] args, object target)
        {
            var ctx = ContextRegistry.GetContext();
            var auditService = ctx["auditService"] as IAuditService;
            string nameMethod = method.Name;
            string nameHistorico = "";

            if (nameMethod == "EliminarEntity")
                nameHistorico = args[1] + "DetalleHist";
            else if (nameMethod.StartsWith("Guardar"))
                nameHistorico = nameMethod.Substring(7);


            if (auditService.IdsDetalleHistorico.ContainsKey(nameHistorico))
            {
                var historico = auditService.IdsDetalleHistorico[nameHistorico];
                auditService.ObjectDao.UpdateHistoricaHija(nameHistorico, historico.ids, historico.idPadre);
            }
        }
        
    }
}
