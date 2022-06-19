using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MiApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationSettings.AppSettings["DefaultConnection"]);
            }
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Seguros> Seguros { get; set; }

        public DbSet<Asegurados> Asegurados { get; set; }


        
    }




    
}