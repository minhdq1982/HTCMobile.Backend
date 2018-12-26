using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HTCMobile.Authorization;

namespace HTCMobile
{
    [DependsOn(
        typeof(HTCMobileCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HTCMobileApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HTCMobileAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HTCMobileApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
