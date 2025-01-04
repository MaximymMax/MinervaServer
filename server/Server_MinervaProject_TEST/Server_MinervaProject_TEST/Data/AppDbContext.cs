using Microsoft.EntityFrameworkCore;
using Server_MinervaProject_TEST.Models;

namespace Server_MinervaProject_TEST.Data
{

    public class AppDbContext : DbContext
    {
        //public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Achievements> Achievements { get; set; }
        public DbSet<Account_types> Account_types { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
