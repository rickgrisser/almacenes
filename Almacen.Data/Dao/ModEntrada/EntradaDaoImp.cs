using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Almacen.Data.Dao.ModEntrada
{
    public class EntradaDaoImp : GenericDaoImp<Entrada, int>, IEntradaDao
    {
        [Transaction(ReadOnly = true)]
        public int NumeroEntrada(int intAnio, string strAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Entrada.NumeroMaxEntrada");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<int>()+1;
        }

        [Transaction(ReadOnly = true)]
        public long IdEntrada()
        {
            var query = CurrentSession.GetNamedQuery("Entrada.MaxId");
            //query.SetParameter("intAnio", intAnio);
            //query.SetParameter("strAlmacen", strAlmacen);
            return query.UniqueResult<long>();
        }
        
        [Transaction(ReadOnly = true)]
        public bool EntradaExiste(int intAnio, string strAlmacen, int numeroEntrada)
        {
            var result = false;
            var query = CurrentSession.GetNamedQuery("Entrada.EntradaExiste");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intNumeroEntrada", numeroEntrada);
            if (query.UniqueResult<Int64>() > 0)
            {
                result = true;
            }
            return result;
        }

        [Transaction(ReadOnly = true)]
        public Entrada CargaEntrada(int intAnio, string strAlmacen, int numeroEntrada, int intIdUsuario)
        {
            var query = CurrentSession.GetNamedQuery("Entrada.CargaEntrada");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intNumeroEntrada", numeroEntrada);
            query.SetParameter("intIdUsuario", intIdUsuario);
            return query.UniqueResult<Entrada>();
        }

        [Transaction(ReadOnly = true)]
        public DateTime CargaUltimaFecha(Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Entrada.CargaUltimaFecha");
            query.SetParameter("objAlmacen", objAlmacen);
            return query.UniqueResult<DateTime>();
        }

        [Transaction(ReadOnly = true)]
        public Entrada CargaSoloEntrada(int intAnio, string strAlmacen, int numeroEntrada)
        {
            var query = CurrentSession.GetNamedQuery("Entrada.CargaSoloEntrada");
            query.SetParameter("intAnio", intAnio);
            query.SetParameter("strAlmacen", strAlmacen);
            query.SetParameter("intNumeroEntrada", numeroEntrada);
            return query.UniqueResult<Entrada>();
        }

        [Transaction(ReadOnly = true)]
        public IList<object[]> RptEntradaFolio(DateTime datFechaIni, DateTime datFechaFin, Entities.Almacen objAlmacen)
        {
            var query = CurrentSession.GetNamedQuery("Entrada.RptEntradaFolio");
            query.SetParameter("datFechaIni", datFechaIni);
            query.SetParameter("datFechaFin", datFechaFin);
            query.SetParameter("objAlmacen", objAlmacen);
            return query.List<object[]>();

        }
    }
}
