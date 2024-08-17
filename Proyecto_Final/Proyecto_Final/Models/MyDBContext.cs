using Microsoft.EntityFrameworkCore;

namespace Proyecto_Final.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() { }
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasKey(e => e.IdCliente);
        }
    }
}
