using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cyf.MpaCore.MultiTenancy.Dto;

namespace Cyf.MpaCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

