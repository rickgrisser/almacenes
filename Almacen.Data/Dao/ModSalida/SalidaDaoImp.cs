using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModSalida
{
    public class SalidaDaoImp : GenericDaoImp<Salida, int>, ISalidaDao
    {
        [Transaction(ReadOnly = true)]
        public int NumeroSalida(int intAnio, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Salida.NumeroMaxSalida");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<int>() + 1;
        }

        [Transaction(ReadOnly = true)]
        public DateTime CargaUltimaFecha(Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Salida.CargaUltimaFecha");
            query.SetParameter("objAlmacen", objAlmacen);
            return query.UniqueResult<DateTime>();
        }

        [Transaction(ReadOnly = true)]
        public bool SalidaExiste(int intAnio, string strAlmacen, int intNumSalida)
        {
            var result = false;
            var query = CurrentSession.GetNamedQuery("Salida.SalidaExiste");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intNumSalida", intNumSalida);
            if (query.UniqueResult<Int64>() > 0)
            {
                result = true;
            }
            return result;
        }

        [Transaction(ReadOnly = true)]
        public int IdSalida()
        {
            var query = CurrentSession.GetNamedQuery("Salida.MaxId");
            //query.SetParameter("intAnio", intAnio);
            //query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<int>();
        }

        [Transaction(ReadOnly = true)]
        public Salida CargaSalida(int intAnio, string strAlmacen, int intNumeroSalida, int intIdUsuario)
        {
            var query = CurrentSession.GetNamedQuery("Salida.CargaSalida");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intNumeroSalida", intNumeroSalida);
            query.SetParameter("intIdUsuario", intIdUsuario);
            return query.UniqueResult<Salida>();
        }
    }
}
