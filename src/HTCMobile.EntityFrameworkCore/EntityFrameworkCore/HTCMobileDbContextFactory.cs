using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HTCMobile.Configuration;
using HTCMobile.Web;

namespace HTCMobile.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HTCMobileDbContextFactory : IDesignTimeDbContextFactory<HTCMobileDbContext>
    {
        public HTCMobileDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HTCMobileDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HTCMobileDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HTCMobileConsts.ConnectionStringName));

            return new HTCMobileDbContext(builder.Options);
        }
    }
}
