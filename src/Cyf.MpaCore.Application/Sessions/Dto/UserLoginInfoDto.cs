using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Cyf.MpaCore.Authorization.Users;

namespace Cyf.MpaCore.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
