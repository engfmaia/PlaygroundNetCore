using Microsoft.EntityFrameworkCore;
using Playground.Data.DbContext;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Playground.Data.RepositoryBase
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected PlaygroundDbContext _dbContext { get; set; }

        public RepositoryBase(PlaygroundDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T entity)
        {
            _dbContext.Set<T>().AddAsync(entity);
        }

        public async Task<T> ReadAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _dbContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>()
                .Where(expression).AsNoTracking();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
