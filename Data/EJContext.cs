using EloctrnicJournal_EF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace EloctrnicJournal_EF.Data
{
    public class EJContext : DbContext
    {
        public static EJContext context;
        public DbSet<Students> Students => Set<Students>();
        public DbSet<Parents> Parents => Set<Parents>();
        public DbSet<Teachers> Teacher => Set<Teachers>();

        public EJContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public static EJContext GetContext()
        {
            if (context == null)
                context = new EJContext();
            return context;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ElectronicJournal.db"); ;
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parents>();
            modelBuilder.Entity<Teachers>();
            modelBuilder.Entity<Students>();
        }
    }
}
