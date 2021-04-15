using Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Database
{
    public sealed class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable(nameof(Employee), Constant.SchemaName);

            builder.HasKey(empl => empl.Id);

            builder.Property(empl => empl.Id).ValueGeneratedOnAdd().IsRequired();

            builder.Property(empl => empl.Status).IsRequired();

            builder.Property(empl => empl.FirstName).HasMaxLength(100);

            builder.Property(empl => empl.LastName).HasMaxLength(100);

            builder.Property(empl => empl.Email).HasMaxLength(100).IsRequired();
            builder.HasIndex(empl => empl.Email).IsUnique();

            builder.HasOne(empl => empl.User).WithOne(u => u.Employee).HasForeignKey<Employee>(empl => empl.UserId).IsRequired();
            builder.HasIndex(empl => empl.UserId).IsUnique();

            builder.Property(empl => empl.Badge).HasMaxLength(50).IsRequired();
            builder.HasIndex(empl => empl.Badge).IsUnique();



            builder.HasOne(empl => empl.Manager).WithMany().HasForeignKey(empl => empl.ManagerId);

            builder.Property(empl => empl.Resign);


        }
    }
}
