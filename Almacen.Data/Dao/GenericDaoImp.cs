using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NHibernate.Type;
using Almacen.Data.Entities;
using Spring.Stereotype;
using Spring.Transaction.Interceptor;
using NHibernate;
using NHibernate.Criterion;



namespace Almacen.Data.Dao
{
   
        /// <summary>
        /// Implementacion de los metodos comunes
        /// </summary>
        /// <typeparam name="TE">Entidad</typeparam>
        /// <typeparam name="TId">Id</typeparam>
        [Repository]
        public abstract class GenericDaoImp<TE, TId> : IGenericDao<TE, TId>
        {
            public ISessionFactory SessionFactory { get; set; }

            protected ISession CurrentSession
            {
                get { return SessionFactory.GetCurrentSession(); }
            }

            /// <summary>
            /// /
            /// </summary>
            /// <param name="entity">Entidad a persistir</param>
            /// <returns>El id generado por la estrategia</returns>
            [Transaction]
            public virtual TId Insert(TE entity)
            {
                return (TId)CurrentSession.Save(entity);
            }

            [Transaction]
            public void Update(TE entity)
            {
                CurrentSession.SaveOrUpdate(entity);
            }

            [Transaction]
            public TE Merge(TE entity)
            {

                return (TE)CurrentSession.Merge(entity);
            }


            [Transaction]
            public void Delete(TE entity)
            {
                CurrentSession.Delete(entity);
            }

            [Transaction]
            public void DeleteAll(IList<TE> entity)
            {
                foreach (var e in entity)
                {
                    CurrentSession.Delete(e);
                }
            }

            [Transaction(ReadOnly = true)]
            public TE Get(TId id)
            {
                return CurrentSession.Get<TE>(id);
            }

            [Transaction(ReadOnly = true)]
            public IList<TE> FindAll(){   
                
                var crit = CurrentSession.CreateCriteria(typeof(TE));
                return crit.List<TE>();
            }

            [Transaction(ReadOnly = true)]
            public DateTime FechaServidor()
            {
                var query = CurrentSession.GetNamedQuery("Util.FechaServidor");
                return query.UniqueResult<DateTime>();
            }

            [Transaction(ReadOnly = true)]
            public IList<T> CargarCatalogo<T>()
            {
                var crit = CurrentSession.CreateCriteria(typeof(T));
                return crit.List<T>();
            }


            [Transaction(ReadOnly = true)]
            public IList<TB> FindAllWhere<T,TB>(object[] campos, object[] whereAnd)
            {
                var crit = CurrentSession.CreateCriteria(typeof(T));
                var conjunction = Restrictions.Conjunction();


                //Se agregan las condiciones
                for (int i = 0; i < whereAnd.Length; i += 2)
                {
                    var cond = Restrictions.Eq(whereAnd[i].ToString(), whereAnd[i + 1]);
                    //Se obtienen los titulos de la tabla
                    conjunction.Add(cond);
                    crit.Add(conjunction);

                }

                var pl = Projections.ProjectionList();

                PropertyInfo[] myFieldInfo;
                Type myType = typeof(TB);
                // Consigue el tipo de propiedades del PropertyInfo
                myFieldInfo = myType.GetProperties();

                //Se validan los campos del poco
                for (int i = 0; i < myFieldInfo.Length; i++)
                {
                    pl.Add(Projections.SqlProjection(campos[i].ToString(),
                        new String[] { myFieldInfo[i].Name }, new IType[] { NHibernateUtil.String }));
                   
                }
              
                crit.SetProjection(pl);
                crit.SetResultTransformer(NHibernate.Transform.Transformers.AliasToBean(typeof(TB)));
                return crit.List<TB>();
                 

            }//Fin

           


         

        }
    }

