using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity> // Bir entity ve context alıp tekrar eden kod yazılmasını engeller
            where TEntity : class, IEntity, new()
            where TContext : DbContext,  new()
    {
        public void Add(TEntity entity)
        {
            // IDisposable pattern implementaton of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); // Referansı yakala
                addedEntity.State = EntityState.Added; // Ekle
                context.SaveChanges(); // Değişiklikleri Kaydet
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); // Referansı yakala
                deletedEntity.State = EntityState.Deleted; // Sil
                context.SaveChanges(); // Değişiklikleri Kaydet
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null // Eğer filtre belirtilmemişse
                    ? context.Set<TEntity>().ToList() // Listeyi getir
                    : context.Set<TEntity>().Where(filter).ToList(); // Eğer filtre verilmişse filtreli datayı getir
            }
        }

        public List<TEntity> GetAllByKategori(int kategoriId)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); // Referansı yakala
                updatedEntity.State = EntityState.Modified; // Güncelle
                context.SaveChanges(); // Değişiklikleri Kaydet
            }
        }
    }
}
