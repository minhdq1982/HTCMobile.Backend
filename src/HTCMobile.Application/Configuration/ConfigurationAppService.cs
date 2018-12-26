using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HTCMobile.Configuration.Dto;

namespace HTCMobile.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HTCMobileAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
