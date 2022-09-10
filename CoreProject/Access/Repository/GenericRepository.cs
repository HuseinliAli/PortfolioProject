using Access.Abstract;
using Access.Concrete;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, IEntity, new()
    {
        public void Add(T entity)
        {
            using(Context context = new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State=EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (Context context = new Context())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State=EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(int id)
        {
            using (Context context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetAll()
        {
            using (Context context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Update(T entity)
        {
            using(Context context = new Context())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
