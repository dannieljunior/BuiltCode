using application.Contracts;
using application.Repository;
using application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace application.Helpers
{
    public static class ServiceCollectionEx
    {
        public static void AddDependencies(this IServiceCollection pServicesCollection)
        {
            pServicesCollection.AddScoped<IUow, Uow>();
            pServicesCollection.AddScoped<IDoctorService, DoctorsService>();
        }
    }
}