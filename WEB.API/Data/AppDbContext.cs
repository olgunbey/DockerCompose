using Microsoft.EntityFrameworkCore;

namespace WEB.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(y => y.Id);
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
