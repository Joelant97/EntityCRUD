using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityCRUD.Models
{
    public partial class ENTITYCRUDContext : DbContext
    {
        public ENTITYCRUDContext()
        {
        }

        public ENTITYCRUDContext(DbContextOptions<ENTITYCRUDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
