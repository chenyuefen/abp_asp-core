using System.Collections.Generic;
using Cyf.MpaCore.Roles.Dto;

namespace Cyf.MpaCore.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
