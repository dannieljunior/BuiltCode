using System.Collections.Generic;
using System.Threading.Tasks;
using application.Models;

namespace application.Contracts
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetDoctorsAsync();
    }
}