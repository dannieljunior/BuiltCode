using System;
using System.Linq;
using application.Models;
using Microsoft.EntityFrameworkCore;

namespace application.Data
{
    public class BuiltCodeContext : DbContext
    {
        public BuiltCodeContext(DbContextOptions<BuiltCodeContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder pModelBuilder)
        {
            base.OnModelCreating(pModelBuilder);

            //todo buscar configurações de entidades por reflexão

            // var teste = AppDomain.CurrentDomain
            //     .GetAssemblies()
            //     .Where(a => a.GetName().Name != "EntityFramework");
            // {
            //     var configTypes = assembly
            //         .GetTypes()
            //         .Where(t => t.BaseType != null
            //                     && t.BaseType.IsGenericType
            //                     && t.BaseType.GetGenericTypeDefinition() == typeof(EntidadeBaseMap<>));

            //     foreach (var type in configTypes)
            //     {
            //         var entityType = type.BaseType.GetGenericArguments().Single();

            //         var entityConfig = assembly.CreateInstance(type.FullName);
            //         addMethod.MakeGenericMethod(entityType)
            //             .Invoke(pModelBuilder.Configurations, new object[] { entityConfig });
            //     }
            // }

            pModelBuilder.ApplyConfiguration(new DoctorEntityConfiguration());
            pModelBuilder.ApplyConfiguration(new PatientEntityConfiguration());
        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
    }
}