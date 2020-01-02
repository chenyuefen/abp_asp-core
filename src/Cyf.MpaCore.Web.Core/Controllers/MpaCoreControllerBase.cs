using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Cyf.MpaCore.Controllers
{
    public abstract class MpaCoreControllerBase: AbpController
    {
        protected MpaCoreControllerBase()
        {
            LocalizationSourceName = MpaCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
