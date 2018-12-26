using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HTCMobile.EntityFrameworkCore
{
    public static class HTCMobileDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HTCMobileDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HTCMobileDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
