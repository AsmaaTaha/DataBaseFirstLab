using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class Repository<TEntity,TContext> : IRepository<TEntity>
        where TEntity:class
        where TContext : DbContext,new()

    {
        TContext context;
        DbSet<TEntity> Set;
        public Repository(TContext context)
        {
            this.context = context;
            this.Set = context.Set<TEntity>();
        }
        public TEntity Add(TEntity entity)
        {
            Set.Add(entity);
          return context.SaveChanges() > 0 ? entity :null;
        }

        public bool Delete(TEntity entity)
        {
            Set.Remove(entity);
            return context.SaveChanges() > 0 ;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Set;
        }

        public TEntity GetById(params object[] id)
        {
            return Set.Find(id);
        }

        public bool Update(TEntity entity)
        {
            Set.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }
    }
}
