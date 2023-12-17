using AquaFree2.Models;
using Microsoft.EntityFrameworkCore;

namespace AquaFree2.Contexto
{
    public class MiContext:DbContext
    {
        public MiContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
