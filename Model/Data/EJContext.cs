using EloctrnicJournal_EF.Model;
using Microsoft.EntityFrameworkCore;

namespace EloctrnicJournal_EF.Data
{
    public class EJContext : DbContext
    {
        public static EJContext context;
        public DbSet<Student> Student => Set<Student>();
        public DbSet<Parent> Parent => Set<Parent>();
        public DbSet<Teacher> Teacher => Set<Teacher>();


        public EJContext()
        {
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
            optionsBuilder.UseSqlServer(@"Server=(local);Database=ElectronicJournal;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>();
            modelBuilder.Entity<Teacher>();
            modelBuilder.Entity<Student>();
        }
    }
}
