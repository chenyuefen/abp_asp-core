using System.Threading.Tasks;
using Abp.Application.Services;
using Cyf.MpaCore.Sessions.Dto;

namespace Cyf.MpaCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
