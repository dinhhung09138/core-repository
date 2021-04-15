using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Database
{
    public sealed class Context : DbContext
    {
        public Context(DbContextOptions option) : base(option) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly).Seed();
        }
    }
}
