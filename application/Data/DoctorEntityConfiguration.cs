using application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace application.Data
{
    public class DoctorEntityConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Crm).IsRequired();
            builder.Property(p => p.CrmUf).IsRequired();
            builder.HasIndex(p => new { p.Crm, p.CrmUf }).IsUnique().HasName("IX_UNQ_DOCTOR_CRM");
        }
    }
}