using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Prueba_Desarrollador.Models.Db;

public partial class GestionBibliotecaContext : DbContext
{
    public GestionBibliotecaContext()
    {
    }

    public GestionBibliotecaContext(DbContextOptions<GestionBibliotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autore> Autores { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-VL0HIE0;Database=GestionBiblioteca;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autore>(entity =>
        {
            entity.HasKey(e => e.AutorId).HasName("PK__Autores__F58AE9091F2A03EA");

            entity.Property(e => e.AutorId).HasColumnName("AutorID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Libros__3214EC2725226FA1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AutorId).HasColumnName("AutorID");
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.Autor).WithMany(p => p.Libros)
                .HasForeignKey(d => d.AutorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Libros_Autores");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
