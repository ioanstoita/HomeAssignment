using System.Collections.Generic;
using System.Threading.Tasks;

namespace HA.Repositories
{
    public interface IRepository<TEntity> where TEntity:class
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(object Id);
        TEntity Add(TEntity entity);
        void Remove(TEntity entity);
    }
}