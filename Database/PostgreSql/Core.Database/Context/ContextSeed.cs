using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;

namespace Core.Database
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            SeedUser(builder);
            SeedEmployee(builder);
        }

        private static void SeedUser(this ModelBuilder builder)
        {
            builder.Entity<User>(m =>
            {
                m.HasData(new
                {
                    Id = 1L,
                    UserName = "hung",
                    Password = "1h763hdJDHSLKD94804DHIDHFDK324435dkHDHD"
                });
            });
        }

        private static void SeedEmployee(this ModelBuilder builder)
        {
            builder.Entity<Employee>(m =>
            {
                m.HasData(new
                {
                    Id = 1L,
                    Name = "Tran Dinh Hung",
                    Address = "Ho Chi Minh",
                    Birthday = DateTime.Now,
                    UserId = 1L
                });
            });
        }
    }
}
