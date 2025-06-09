using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using Microsoft.EntityFrameworkCore;

namespace CDatos.Contexts
{
        public partial class Context : DbContext
        {
            public Context()
            {
            }
            public Context(DbContextOptions<Context> options)
                : base(options)
            {
            }

            public virtual DbSet<Alquiler> Alquiler { get; set; }
            public virtual DbSet<Bicicleta> Bicicleta { get; set; }
            public virtual DbSet<Cliente> Cliente { get; set; }
            public virtual DbSet<Empleado> Empleado { get; set; }
            public virtual DbSet<Estacion> Estacion { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Ejercicio3;Integrated Security=True;TrustServerCertificate=true");
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

                modelBuilder.Entity<Alquiler>(entity =>
                {
                    entity.HasKey(e => e.AlquilerId)
                          .HasName("PK_ID_ALQUILER");
                   

                });
                
            modelBuilder.Entity<Cliente>(entity =>
                {
                    entity.HasMany(e => e.HistAlquileres)
                          .WithOne(e => e.Cliente)
                          .HasForeignKey("IdClientes")
                          .IsRequired();
                });

                OnModelCreatingPartial(modelBuilder);
            }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }
    }
}
