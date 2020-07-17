using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace application.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync();
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> pQueryFun);
        Task AddAsync(T pEntity);
        Task UpdateAsync(T pEntity);
        Task DeleteAsync(Guid pId);
    }
}