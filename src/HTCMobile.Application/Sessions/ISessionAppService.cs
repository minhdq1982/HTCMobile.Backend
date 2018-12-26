using System.Threading.Tasks;
using Abp.Application.Services;
using HTCMobile.Sessions.Dto;

namespace HTCMobile.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
