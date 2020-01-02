using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Cyf.MpaCore.Configuration.Dto;

namespace Cyf.MpaCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MpaCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
