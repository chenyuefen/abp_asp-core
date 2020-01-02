using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Cyf.MpaCore.Configuration;
using Cyf.MpaCore.Web;

namespace Cyf.MpaCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MpaCoreDbContextFactory : IDesignTimeDbContextFactory<MpaCoreDbContext>
    {
        public MpaCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MpaCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MpaCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MpaCoreConsts.ConnectionStringName));

            return new MpaCoreDbContext(builder.Options);
        }
    }
}
