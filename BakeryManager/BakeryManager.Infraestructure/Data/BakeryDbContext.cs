using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BakeryManager.Infraestructure.Data
{
    public BakeryDbContext(DbContextOptions<BakeryDbContext> options) : base(options)
    {
    }

    public class BakeryDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<PedidoItem> PedidoItems { get; set; }
        public DbSet<RecetaIngrediente> RecetaIngredientes { get; set; }

        public BakeryDbContext(DbContextOptions<BakeryDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(p => p.Precio)
                .HasColumnType("decimal(10,2)");

                Eentity.HasOne(p => p.Categoria)
                .WithMany()
                .HasForeignKey(p => p.CategoriaId);
            });

            modelBuilder.Entity<PedidoItem>(entity =>

            {
                entity.Property(pi => pi.PrecioUnitario)
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(pi => pi.Pedido)
                    .WithMany(p => p.Items)
                    .HasForeignKey(pi => pi.PedidoId);

                entity.HasOne(pi => pi.Producto)
                    .WithMany()
                    .HasForeignKey(pi => pi.ProductoId);
            });
            modelBuilder.Entity<RecetaIngrediente>(entity =>
            {
                entity.HasOne(ri => ri.Receta)
                    .WithMany(r => r.Ingredientes)
                    .HasForeignKey(ri => ri.RecetaId);

                entity.HasOne(ri => ri.Producto)
                    .WithMany()
                    .HasForeignKey(ri => ri.ProductoId);
            });
        }

    }
}
