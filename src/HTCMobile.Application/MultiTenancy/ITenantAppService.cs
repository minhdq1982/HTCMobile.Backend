using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HTCMobile.MultiTenancy.Dto;

namespace HTCMobile.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
