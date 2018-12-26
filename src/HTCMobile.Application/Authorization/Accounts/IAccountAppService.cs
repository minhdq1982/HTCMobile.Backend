using System.Threading.Tasks;
using Abp.Application.Services;
using HTCMobile.Authorization.Accounts.Dto;

namespace HTCMobile.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
