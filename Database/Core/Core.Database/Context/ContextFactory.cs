using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Core.Database
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            const string connectionString = "server=127.0.0.1;user id=root;password=;port=3306;database=SHDS;";

            return new Context(new DbContextOptionsBuilder<Context>().UseMySQL(connectionString).Options);
        }
    }
}
