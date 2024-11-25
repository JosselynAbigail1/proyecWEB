using Microsoft.EntityFrameworkCore;
using proyecWEB.Shared.Entitis;

namespace proyecWEB.Backend.Data
{
    public class DataContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        public DataContext(DbContextOptions<DbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        { }

        public DbSet<marcas> marcas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<marcas>().HasIndex(x => x.Id).IsUnique();
        }
    }
}