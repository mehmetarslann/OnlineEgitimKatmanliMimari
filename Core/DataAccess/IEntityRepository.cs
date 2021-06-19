using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity, new() // Generic Repository Design Pattern && Generic Constraint && Gönderilen veri referans tip olmalı && IEntity veya IEntity'den referans alan bir sınıf. && New'lenebilir olmalı. IEntity'i devre dışı bırakmak için kullandık.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByKategori(int kategoriId);
    }
}
