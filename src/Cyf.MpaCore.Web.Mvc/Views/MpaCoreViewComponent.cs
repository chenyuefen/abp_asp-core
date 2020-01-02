using Abp.AspNetCore.Mvc.ViewComponents;

namespace Cyf.MpaCore.Web.Views
{
    public abstract class MpaCoreViewComponent : AbpViewComponent
    {
        protected MpaCoreViewComponent()
        {
            LocalizationSourceName = MpaCoreConsts.LocalizationSourceName;
        }
    }
}
