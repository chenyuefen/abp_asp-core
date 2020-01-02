using Abp.AutoMapper;
using Cyf.MpaCore.Authentication.External;

namespace Cyf.MpaCore.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
