using application.Contracts;
using application.Repository;

namespace application.Services
{
    public abstract class ServiceBase
    {
        protected readonly IUow uow;
        public ServiceBase(IUow pUow) 
        { 
            uow = pUow;
        }
    }
}