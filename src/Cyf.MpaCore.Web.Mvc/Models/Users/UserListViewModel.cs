using System.Collections.Generic;
using Cyf.MpaCore.Roles.Dto;
using Cyf.MpaCore.Users.Dto;

namespace Cyf.MpaCore.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
