
using Authentication.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication.DAL.Database
{
   public class DatabaseContext :
        IdentityDbContext<
        ApplicationUser, ApplicationRole, string,
        ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
        ApplicationRoleClaim, ApplicationUserToken>
    {
        public class OptionBuild
        {
            public OptionBuild()
            {
                settings = new AppConfiguration();
                optsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                optsBuilder.UseSqlServer(settings.connstring);
                opts = optsBuilder.Options;
            }

            public DbContextOptionsBuilder<DatabaseContext> optsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> opts { get; set; }
            private AppConfiguration settings { get; set; }
        }


        public static OptionBuild ops = new OptionBuild();

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        
        public DbSet<Citizen> citizens { get; set; }
        public DbSet<Criminal> criminals { get; set; }
        public DbSet<Foreigner> foreigners { get; set; }
        public DbSet<Officer> officers { get; set; }
        public DbSet<Station> stations { get; set; }
        public DbSet<Suspect> suspects { get; set; }
        public DbSet<Work> works { get; set; }

    }
}
