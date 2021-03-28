using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Domain;

namespace Core.Database
{
    public sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User), Constant.SchemaName);

            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(m => m.UserName).HasMaxLength(255).IsRequired();
            builder.HasIndex(m => m.UserName).IsUnique();

            builder.Property(m => m.Password).HasMaxLength(500).IsRequired();
        }
    }
}
