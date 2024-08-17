using Microsoft.EntityFrameworkCore;

namespace TSNP222323.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pelicula>().HasKey(c=>c.IdPeliculas);
        }
    }
}
