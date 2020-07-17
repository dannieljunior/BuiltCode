using application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace application.Data
{
    public class PatientEntityConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.BirthDate).IsRequired();
            builder.Property(p => p.Cpf).IsRequired();
            builder.HasIndex(p => new { p.Cpf }).IsUnique(true).HasName("IX_UNQ_PATIENT_CPF");

            //todo: criar validação fluent para que paciente não possua pacientes duplicados
        }
    }
}