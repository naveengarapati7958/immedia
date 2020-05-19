using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.DataLayer
{
    public class IMMEDIADbContext: DbContext
    {
        public IMMEDIADbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<VenueModel> Venues { get; set; }
        public DbSet<PhotoModel> Photos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VenueModel>().ToTable("Venue");
            modelBuilder.Entity<PhotoModel>().ToTable("Photo");
        }

    }
}
