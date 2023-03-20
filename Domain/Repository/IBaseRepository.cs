using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Respository
{
    internal interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<ICollection<TEntity>> GetAllAsync();
        Task<ICollection<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        
        Task<TEntity?> GetByIdAsync(int id);
        Task<TEntity?> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        
        Task InsertAsync(TEntity entity);
        //void AddRange(IEnumerable<TEntity> entities);
        Task UpdateAsync(TEntity entity);
        //void UpdateRange(IEnumerable<TEntity> entities);
        Task RemoveAsync(TEntity entity);
    }
}
