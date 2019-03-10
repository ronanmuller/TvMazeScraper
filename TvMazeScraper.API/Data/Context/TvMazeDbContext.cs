using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TvMazeScraper.API.Models;


namespace TvMazeScraper.API.Data.Context
{
    public class TvMazeDbContext : DbContext
    {
        public TvMazeDbContext(DbContextOptions options)
        : base(options)
        {

        }

        public DbSet<Show> Shows { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<CastShow> CastShows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CastShow>().HasKey(c => new { c.CastId, c.ShowId });
        }
    }
}
