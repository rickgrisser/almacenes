using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Almacen.Data.Entities;

namespace Almacen.Data.Dao
{
    public interface IGenericDao<TE, TId>
    {
        TId Insert(TE entity);
        void Update(TE entity);
        void Delete(TE entity);
        void DeleteAll(IList<TE> objects);
        TE Merge(TE entity);
        TE Get(TId id);
        IList<TE> FindAll();
        IList<T> CargarCatalogo<T>();
        DateTime FechaServidor();
        IList<TB> FindAllWhere<T,TB>(object[] campos, object[] whereAnd);

    }
}
