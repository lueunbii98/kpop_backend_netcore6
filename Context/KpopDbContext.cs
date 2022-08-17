using Microsoft.EntityFrameworkCore;
using KpopProject.Models;

namespace KpopProject.Context
{
    public class KpopDbContext : DbContext
    {
        public KpopDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=127.0.0.1;database=KpopDb;uid=root;password=;", new MySqlServerVersion(new Version(8, 0, 11)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<Member> Member { get; set; }
    }
}
