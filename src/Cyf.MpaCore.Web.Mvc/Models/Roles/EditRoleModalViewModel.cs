using Abp.AutoMapper;
using Cyf.MpaCore.Roles.Dto;
using Cyf.MpaCore.Web.Models.Common;

namespace Cyf.MpaCore.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
