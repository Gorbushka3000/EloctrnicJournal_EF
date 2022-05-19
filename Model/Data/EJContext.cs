using EloctrnicJournal_EF.Model;
using Microsoft.EntityFrameworkCore;

namespace EloctrnicJournal_EF.Data
{
    public class EJContext : DbContext
    {
        public static EJContext context;
        public DbSet<Student> Student => Set<Student>();
        public DbSet<Teacher> Teacher => Set<Teacher>();
        public DbSet<Grade> Grades => Set<Grade>();
        public DbSet<Passes> Passes => Set<Passes>();
        public DbSet<Lesson> Lessons => Set<Lesson>();
        public DbSet<ClassNumber> ClassNumbers => Set<ClassNumber>();
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
            optionsBuilder.UseSqlServer(@"Server=(local);Database=ElectronicJournal;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>();
            modelBuilder.Entity<Student>();
            modelBuilder.Entity<Grade>();
        }
    }
}
