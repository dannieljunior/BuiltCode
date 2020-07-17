using application.Contracts;
using application.Repository;

namespace application.Services
{
    public abstract class ServiceBase
    {
        protected readonly Uow uow;
        public ServiceBase(IUow pUow) 
        { 
            uow = pUow;
        }
    }
}