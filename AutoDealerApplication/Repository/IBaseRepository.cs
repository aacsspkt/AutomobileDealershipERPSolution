using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealerApplication.Respository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        ICollection<TEntity> GetAll();
        
        TEntity? GetElementById(Guid id);
        TEntity? SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        
        bool Any(Expression<Func<TEntity, bool>> predicate);
        
        void Insert(TEntity entity);
        //void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        //void UpdateRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
    }
}
