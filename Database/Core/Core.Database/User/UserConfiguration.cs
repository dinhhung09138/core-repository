using Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Database
{
    public sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));

            builder.HasKey(user => user.Id);
            builder.Property(user => user.Id).ValueGeneratedOnAdd().IsRequired();

            builder.HasIndex(user => user.Login).IsUnique();
            builder.Property(user => user.Login).HasMaxLength(100).IsRequired();

            builder.Property(user => user.Password).HasMaxLength(1000).IsRequired();

            builder.Property(user => user.Salt).HasMaxLength(1000).IsRequired();
        }
    }
}
