using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Cyf.MpaCore.Authorization.Roles;
using Cyf.MpaCore.Authorization.Users;
using Cyf.MpaCore.MultiTenancy;
using Cyf.MpaCore.PhoneBooks.PhoneNumbers;
using Cyf.MpaCore.PhoneBooks.Persons;

namespace Cyf.MpaCore.EntityFrameworkCore
{
    public class MpaCoreDbContext : AbpZeroDbContext<Tenant, Role, User, MpaCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MpaCoreDbContext(DbContextOptions<MpaCoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");

            base.OnModelCreating(modelBuilder);
        }
    }
}
