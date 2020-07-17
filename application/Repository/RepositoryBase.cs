using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using application.Contracts;
using application.Data;
using Microsoft.EntityFrameworkCore;

namespace application.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly DbContext context;

        protected readonly DbSet<T> dbSet;

        public RepositoryBase(DbContext pContext)
        {
            context = pContext;
            dbSet = context.Set<T>();
        }

        public virtual async Task AddAsync(T pEntity)
        {
            await dbSet.AddAsync(pEntity);
        }

        public virtual async Task DeleteAsync(Guid pId)
        {
            var pEntityToDelete = await dbSet.FindAsync(pId);
            dbSet.Remove(pEntityToDelete);
        }

        public virtual async Task<IEnumerable<T>> GetAsync()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> pQueryFun)
        {
            return await dbSet.Where(pQueryFun).ToListAsync();
        }

        public virtual async Task UpdateAsync(T pEntity)
        {
            await Task.FromResult(dbSet.Attach(pEntity));
        }
    }
}