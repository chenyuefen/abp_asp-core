using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Cyf.MpaCore.Authorization;

namespace Cyf.MpaCore
{
    [DependsOn(
        typeof(MpaCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MpaCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MpaCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MpaCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
