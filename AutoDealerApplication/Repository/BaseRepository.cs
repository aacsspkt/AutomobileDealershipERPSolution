using System.Linq.Expressions;
using AutoDealerApplication.AppState;
using AutoDealerApplication.Respository;
using Microsoft.EntityFrameworkCore;

namespace AutoDealerApplication.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationContext context;
        protected readonly DbSet<TEntity> dbset;

        public BaseRepository(ApplicationContext context)
        {
            this.context = context;
            this.dbset = context.Set<TEntity>();
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return this.dbset.Any(predicate);
        }

        public ICollection<TEntity> GetAll()
        {
            return this.dbset.ToHashSet();
        }

        public  TEntity? GetElementById(Guid id)
        {
            return this.dbset.Find(id);
        }

        public void Insert(TEntity entity)
        {
            this.dbset.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            this.dbset.Remove(entity);
        }

        public TEntity? SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return this.dbset.SingleOrDefault(predicate);
        }

        public void Update(TEntity entity)
        {
            this.Update(entity);
        }
    }
}
