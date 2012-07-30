using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModRequisicion
{
    public class RequisicionDaoImp : GenericDaoImp<Requisicion, int>, IRequisicionDao
    {
        [Transaction(ReadOnly = true)]
        public int NumeroRequisicion(int intAnio, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Requisicion.NumeroMaxRequisicion");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<int>() + 1;
        }

        [Transaction(ReadOnly = true)]
        public int IdRequisicion()
        {
            var query = CurrentSession.GetNamedQuery("Requisicion.MaxId");
            //query.SetParameter("intAnio", intAnio);
            //query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<int>();
        }

        [Transaction(ReadOnly = true)]
        public bool RequisicionExiste(int intAnio, string strAlmacen, int intNumeroRequisicion)
        {
            var result = false;
            var query = CurrentSession.GetNamedQuery("Requisicion.RequisicionExiste");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intNumeroRequisicion", intNumeroRequisicion);
            if (query.UniqueResult<Int64>() > 0)
            {
                result = true;
            }
            return result;
        }

        [Transaction(ReadOnly = true)]
        public Requisicion CargaRequisicion(int intAnio, string strAlmacen, int intNumeroRequisicion)
        {
            var query = CurrentSession.GetNamedQuery("Requisicion.CargaRequisicion");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intNumeroRequisicion", intNumeroRequisicion);
            return query.UniqueResult<Requisicion>();
        }
    }
}
