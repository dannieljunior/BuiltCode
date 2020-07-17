using System.Threading.Tasks;
using application.Contracts;
using application.Data;
using application.Models;

namespace application.Repository
{
    public class Uow : IUow
    {
        private BuiltCodeContext context;
        private IRepository<Doctor> _doctorsRepository;
        private IRepository<Patient> _patientsRepository;

        public IRepository<Doctor> Doctors => _doctorsRepository;
        public IRepository<Patient> Patients => _patientsRepository;

        public Uow(BuiltCodeContext pContext)
        {
            context = pContext;
            _doctorsRepository = new DoctorsRepository(context);
            _patientsRepository = new PatientsRepository(context);
        }

        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}