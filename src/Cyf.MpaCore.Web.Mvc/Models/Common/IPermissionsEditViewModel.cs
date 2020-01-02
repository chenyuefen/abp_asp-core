using System.Collections.Generic;
using Cyf.MpaCore.Roles.Dto;

namespace Cyf.MpaCore.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}