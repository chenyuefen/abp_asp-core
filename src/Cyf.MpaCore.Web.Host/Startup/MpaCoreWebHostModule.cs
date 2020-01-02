using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Cyf.MpaCore.Configuration;

namespace Cyf.MpaCore.Web.Host.Startup
{
    [DependsOn(
       typeof(MpaCoreWebCoreModule))]
    public class MpaCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MpaCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MpaCoreWebHostModule).GetAssembly());
        }
    }
}
