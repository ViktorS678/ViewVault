using ViewVault.Infrastructure.Data.Common.Moderation;

namespace ViewVault.Infrastructure.Data.Common.Repositories
{
    public interface IDeleteRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IDelete
    {
        IQueryable<TEntity> AllWithDeleted();

        IQueryable<TEntity> AllAsNoTrackingWithDeleted();

        void HardDelete(TEntity entity);

        void Undelete(TEntity entity);
    }
}
