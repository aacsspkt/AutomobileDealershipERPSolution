using System.Linq.Expressions;
using Domain.AppState;
using Domain.Respository;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository
{
    internal class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationContext context;
        protected readonly DbSet<TEntity> dbset;

        public BaseRepository(ApplicationContext context)
        {
            this.context = context;
            this.dbset = context.Set<TEntity>();
        }

        
    }
}
