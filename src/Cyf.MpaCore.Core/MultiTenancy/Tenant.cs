using Abp.MultiTenancy;
using Cyf.MpaCore.Authorization.Users;

namespace Cyf.MpaCore.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
