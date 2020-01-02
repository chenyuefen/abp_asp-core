using System.Threading.Tasks;
using Cyf.MpaCore.Configuration.Dto;

namespace Cyf.MpaCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
