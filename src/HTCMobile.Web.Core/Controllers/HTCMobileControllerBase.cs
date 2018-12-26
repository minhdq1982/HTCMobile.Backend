using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HTCMobile.Controllers
{
    public abstract class HTCMobileControllerBase: AbpController
    {
        protected HTCMobileControllerBase()
        {
            LocalizationSourceName = HTCMobileConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
