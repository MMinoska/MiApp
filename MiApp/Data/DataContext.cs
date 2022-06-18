using Microsoft.EntityFrameworkCore;

namespace MiApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Seguros> Seguros { get; set; }

        public DbSet<Asegurados> Asegurados { get; set; }


        
    }




    
}