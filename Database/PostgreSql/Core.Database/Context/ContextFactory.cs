using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Core.Database
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            const string connectionString = "Host=localhost;Database=UserDb;Username=postgres;Password=hung764119";

            return new Context(new DbContextOptionsBuilder<Context>().UseNpgsql(connectionString).Options);
        }
    }
}
