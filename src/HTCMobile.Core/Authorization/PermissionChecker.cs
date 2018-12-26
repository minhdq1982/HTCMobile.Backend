using Abp.Authorization;
using HTCMobile.Authorization.Roles;
using HTCMobile.Authorization.Users;

namespace HTCMobile.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
