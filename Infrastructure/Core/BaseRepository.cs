using DB.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Core
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity:class where TId : IEquatable<TId>
    {
        public readonly TasksContext context;
        public readonly DbSet<TEntity> DbEntity;

        public BaseRepository(TasksContext context )
        {
            this.context = context;
            this.DbEntity = context.Set<TEntity>();
        }
        public virtual void Create(TEntity entity)
        {
            DbEntity.Add(entity);
            context.SaveChanges();
            
        }

        public virtual bool Exits(Func<TEntity, bool> filter)
        {
            return DbEntity.Any(filter);
        }

        public virtual List<TEntity> GetEntities()
        {
            return DbEntity.ToList();
        }

        public virtual TEntity GetEntityById(TId Id)
        {
            return DbEntity.Find(Id);
        }

        public void Remove(TEntity entity)
        {
            DbEntity.Update(entity);
        }

        public void Update(TEntity entity)
        {
            DbEntity.Update(entity);
        }
    }
}