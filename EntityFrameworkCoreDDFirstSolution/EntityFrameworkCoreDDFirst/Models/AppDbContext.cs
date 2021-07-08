using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreDDFirst.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("server=localhost\\sqlexpress;"
                    + "database=SalesDbMax;"
                    + "trusted_connection=true;");
            };
        }
    }
}
