using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Cyf.MpaCore.Authorization.Roles;
using Cyf.MpaCore.Authorization.Users;
using Cyf.MpaCore.MultiTenancy;

namespace Cyf.MpaCore.EntityFrameworkCore
{
    public class MpaCoreDbContext : AbpZeroDbContext<Tenant, Role, User, MpaCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MpaCoreDbContext(DbContextOptions<MpaCoreDbContext> options)
            : base(options)
        {
        }
    }
}
