using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BmdbWebApi.Models;

namespace BmdbWebApi.Data
{
    public class BmdbWebApiContext : DbContext
    {
        public BmdbWebApiContext (DbContextOptions<BmdbWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<BmdbWebApi.Models.Actor> Actors { get; set; }
    }
}
