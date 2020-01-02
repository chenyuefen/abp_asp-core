using Abp.Authorization;
using Cyf.MpaCore.Authorization.Roles;
using Cyf.MpaCore.Authorization.Users;

namespace Cyf.MpaCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
