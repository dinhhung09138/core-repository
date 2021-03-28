using System;
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

            builder.Property(m => m.Id).ValueGeneratedOnAdd().IsRequired();
            builder.HasIndex(m => m.Id);

            builder.Property(m => m.Name).HasMaxLength(200).IsRequired();

            builder.Property(m => m.Address).HasMaxLength(300);

            builder.Property(m => m.Birthday).IsRequired();

            builder.HasOne(m => m.User).WithMany(u => u.Employees).HasForeignKey(m => m.UserId).OnDelete(DeleteBehavior.Restrict).IsRequired();
        }
    }
}
