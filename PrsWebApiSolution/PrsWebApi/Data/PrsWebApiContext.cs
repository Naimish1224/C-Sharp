using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BmdbWebApi.Models;
using PrsWebApi.Models;

namespace PrsWebApi.Data
{
    public class PrsWebApiContext : DbContext
    {
        public PrsWebApiContext (DbContextOptions<PrsWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<BmdbWebApi.Models.User> Users { get; set; }

        public DbSet<PrsWebApi.Models.Product> Products { get; set; }
        public DbSet<PrsWebApi.Models.Vendor> Vendors { get; set; }
        public DbSet<PrsWebApi.Models.Request> Requests { get; set; }
    }
}
