using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Cyf.MpaCore.Web.Views
{
    public abstract class MpaCoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MpaCoreRazorPage()
        {
            LocalizationSourceName = MpaCoreConsts.LocalizationSourceName;
        }
    }
}
