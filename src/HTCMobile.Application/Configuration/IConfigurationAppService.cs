using System.Threading.Tasks;
using HTCMobile.Configuration.Dto;

namespace HTCMobile.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
