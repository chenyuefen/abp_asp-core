using Abp.Application.Services.Dto;

namespace Cyf.MpaCore.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

