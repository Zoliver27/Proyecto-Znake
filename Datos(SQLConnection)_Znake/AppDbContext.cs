using Entidades_Znake;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Datos
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario_Ent> Usuarios { get; set; }
        public DbSet<Dueno_Ent> Duenos { get; set; }
        public DbSet<Admin_Ent> Administradores { get; set; }
        public DbSet<Gerente_Ent> Gerentes { get; set; }
        public DbSet<Vendedor_Ent> Vendedores { get; set; }
        public DbSet<Cliente_Ent> Clientes { get; set; }
        public DbSet<Proveedor_Ent> Proveedores { get; set; }
        public DbSet<Marca_Ent> Marcas { get; set; }
        public DbSet<Producto_Ent> Productos { get; set; }
        public DbSet<Compra_Ent> Compras { get; set; }
        public DbSet<DetalleCompra_Ent> Detalle_Compra { get; set; }
        public DbSet<Venta_Ent> Ventas { get; set; }
        public DbSet<HistorialAct_Ent> Historial_Actividades { get; set; }
        public DbSet<RecuperarCuenta_Ent> Recuperar_Cuenta { get; set; }
        public DbSet<Carrito_Ent> Carrito { get; set; }
        public DbSet<DetalleCarrito_Ent> Detalle_Carrito { get; set; }

        private static bool usarServidorRemoto = false; //cambiar a true para el uso de la BD remota

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                string nombreConexion = usarServidorRemoto ? "RemoteConnection" : "LocalConnection";
                string cadenaConexion = configuration.GetConnectionString(nombreConexion);

                optionsBuilder.UseSqlServer(cadenaConexion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}