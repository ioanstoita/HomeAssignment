using HA.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return entity;
        }

        public async Task<TEntity> GetAsync(object Id)
        {
            return await _context.Set<TEntity>().FindAsync(Id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}
