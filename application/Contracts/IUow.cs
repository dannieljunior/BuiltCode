using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace application.Contracts
{
    public interface IUow: IDisposable //unit of work
    {
        Task CommitAsync();
        IRepository<Doctor> Doctors;
        IRepository<Patient> Patients;
    }
}