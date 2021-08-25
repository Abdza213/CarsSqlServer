using DTO.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DTO.DataAccess
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var AddItem = context.Entry(item);
                AddItem.State = EntityState.Added;
                context.SaveChanges();

                //2. YOL
                //context.cars.Add(item);
                //context.SaveChanges();
            }
        }

        public void Delete(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var DeleteItem = context.Entry(item);
                DeleteItem.State = EntityState.Deleted;
                context.SaveChanges();

                //2. YOL
                //context.cars.Add(item);
                //context.SaveChanges();
            }
        }

        public void Update(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var UpdateItem = context.Entry(item);
                UpdateItem.State = EntityState.Unchanged;
                context.SaveChanges();
            }
        }

        // ----------------------------

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
    }
}
