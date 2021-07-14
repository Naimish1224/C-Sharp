using BmdbWebApi.Models;
using Microsoft.EntityFrameworkCore;
using PrsWebApi.Models;

namespace PrsWebApi.Data
{
    public class PrsWebApiContext : DbContext
    {
        public PrsWebApiContext(DbContextOptions<PrsWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<BmdbWebApi.Models.User> Users { get; set; }

        public DbSet<PrsWebApi.Models.Product> Products { get; set; }
        public DbSet<PrsWebApi.Models.Vendor> Vendors { get; set; }
        public DbSet<PrsWebApi.Models.Request> Requests { get; set; }
        public DbSet<PrsWebApi.Models.LineItem> LineItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(e =>
            {
                e.HasIndex(p => p.UserName).IsUnique();
            });
            builder.Entity<Vendor>(e =>
            {
                e.HasIndex(p => p.Code).IsUnique();
            });
            builder.Entity<Product>(e =>
            {
                e.HasIndex(p => p.PartNumber).IsUnique();
            });
        }
    }
}
