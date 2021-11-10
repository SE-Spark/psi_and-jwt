using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Authentication.DAL.Database
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();
            var optsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optsBuilder.UseSqlServer(appConfig.connstring);
            return new DatabaseContext(optsBuilder.Options);
        }
    }
}
