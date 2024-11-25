using Microsoft.EntityFrameworkCore;
using proyecWEB.Shared.Entitis;

namespace proyecWEB.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<marcas> marcas MyProperty { get; set; }
}
}