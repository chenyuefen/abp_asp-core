using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Cyf.MpaCore.EntityFrameworkCore
{
    public static class MpaCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MpaCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MpaCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
