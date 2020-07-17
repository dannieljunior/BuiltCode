using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using application.Models;
using Microsoft.EntityFrameworkCore;

namespace application.Repository
{
    public class PatientsRepository : RepositoryBase<Patient>
    {
        public PatientsRepository(DbContext pContext) : base(pContext)
        {
        }

        public override Task AddAsync(Patient pEntity)
        {
            return base.AddAsync(pEntity);
        }

        public override Task DeleteAsync(Guid pId)
        {
            return base.DeleteAsync(pId);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override Task<IEnumerable<Patient>> GetAsync()
        {
            return base.GetAsync();
        }

        public override Task<IEnumerable<Patient>> GetAsync(Expression<Func<Patient, bool>> pQueryFun)
        {
            return base.GetAsync(pQueryFun);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override Task UpdateAsync(Patient pEntity)
        {
            return base.UpdateAsync(pEntity);
        }
    }
}