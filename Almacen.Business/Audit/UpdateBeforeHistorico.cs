using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Spring.Aop;
using Spring.Context.Support;

namespace Almacen.Business.Audit
{
    public class UpdateBeforeHistorico : IMethodBeforeAdvice
    {
        public void Before(MethodInfo method, object[] args, object target)
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
                auditService.IdsDetalleHistorico[nameHistorico] = new Historico();
            else
                auditService.IdsDetalleHistorico.Add(nameHistorico,new Historico());
        }
    }
}
