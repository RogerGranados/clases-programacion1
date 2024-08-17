using Microsoft.EntityFrameworkCore;

namespace TSNP120624_TSNP205523_TSNP222323.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Pelicula> Peliculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pelicula>().HasKey(c=>c.IdPelicula);
        }
        
            
    }

}

