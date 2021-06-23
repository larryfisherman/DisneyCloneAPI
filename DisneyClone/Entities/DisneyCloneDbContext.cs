using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyClone.Entities
{
    public class DisneyCloneDbContext : DbContext
    {
        private string _connectionString = "Server=ALBERT-PC\\DisneyClone;Database=DisneyCloneDb;Trusted_Connection=True;";

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(50);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
