using System.Threading.Tasks;
using Abp.Application.Services;
using Cyf.MpaCore.Authorization.Accounts.Dto;

namespace Cyf.MpaCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
