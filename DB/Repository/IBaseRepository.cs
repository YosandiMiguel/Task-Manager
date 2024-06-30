

using Org.BouncyCastle.Utilities;

namespace DB.Repository
{
    public interface IBaseRepository <TEntity, TId> where TEntity : class where TId : IEquatable<TId>
    {
        TEntity GetEntityById(TId Id);
        List<TEntity> GetEntities();

    }
}
