

using Org.BouncyCastle.Utilities;

namespace DB.Repository
{
    public interface IBaseRepository <TEntity, TId> where TEntity : class where TId : IEquatable<TId>
    {
        TEntity GetEntityById(TId Id);
        List<TEntity> GetEntities();
        bool Exits (Func<TEntity, bool> filter);
        void Create (TEntity entity);
        void Update (TEntity entity);
        void Remove (TEntity entity);

    }
}
