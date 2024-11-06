using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WEB.API.Data
{
    public class DesignTime : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
           var db= new DbContextOptionsBuilder<AppDbContext>();
            db.UseNpgsql("Host=postgres;Port=5432;Database=useradmin;Username=useradmin;Password=secret");
            return new AppDbContext(db.Options);
        }
    }
}
