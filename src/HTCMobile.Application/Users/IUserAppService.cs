using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HTCMobile.Roles.Dto;
using HTCMobile.Users.Dto;

namespace HTCMobile.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
