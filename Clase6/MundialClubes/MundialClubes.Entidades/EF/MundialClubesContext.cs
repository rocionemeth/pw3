using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MundialClubes.Entidades.EF;

public partial class MundialClubesContext : DbContext
{
    public MundialClubesContext()
    {
    }

    public MundialClubesContext(DbContextOptions<MundialClubesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<JugadorEstrella> JugadorEstrellas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MundialClubes;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JugadorEstrella>(entity =>
        {
            entity.HasKey(e => e.IdJugadorEstrella);

            entity.ToTable("JugadorEstrella");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.FotoUrl)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
