using application.Repository;

namespace application.Services
{
    public class PatientsService : ServiceBase
    {
        public PatientsService(Uow pUow) : base(pUow) { }
    }
}