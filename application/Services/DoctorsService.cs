using System.Collections.Generic;
using application.Repository;
using System.Threading.Tasks;
using application.Models;
using application.Contracts;

namespace application.Services
{
    public class DoctorsService : ServiceBase, IDoctorService
    {
        public DoctorsService(IUow pUow) : base(pUow) 
        { 
            uow = (Uow)uow;
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
        {
            return await (uow as Uow).Doctors.GetAsync();
        }
    }
}