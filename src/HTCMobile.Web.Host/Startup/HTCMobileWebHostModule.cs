using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HTCMobile.Configuration;

namespace HTCMobile.Web.Host.Startup
{
    [DependsOn(
       typeof(HTCMobileWebCoreModule))]
    public class HTCMobileWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HTCMobileWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HTCMobileWebHostModule).GetAssembly());
        }
    }
}
