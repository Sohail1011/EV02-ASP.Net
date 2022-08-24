using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class BDNOTAS2021Context : DbContext
    {
        public BDNOTAS2021Context()
        {
        }

        public BDNOTAS2021Context(DbContextOptions<BDNOTAS2021Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Carreras> Carreras { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<Notas> Notas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=BDNOTAS2021;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumnos>(entity =>
            {
                entity.HasKey(e => e.Codalu);

                entity.ToTable("ALUMNOS");

                entity.Property(e => e.Codalu)
                    .HasColumnName("CODALU")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codcar)
                    .HasColumnName("CODCAR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eliminado)
                    .HasColumnName("ELIMINADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.Fecnac)
                    .HasColumnName("FECNAC")
                    .HasColumnType("date")
                    .HasDefaultValueSql("('02/01/2002')");

                entity.Property(e => e.Nomalu)
                    .IsRequired()
                    .HasColumnName("NOMALU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodcarNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.Codcar)
                    .HasConstraintName("FK_ALUMNOS_CODCAR");
            });

            modelBuilder.Entity<Carreras>(entity =>
            {
                entity.HasKey(e => e.Codcar);

                entity.ToTable("CARRERAS");

                entity.Property(e => e.Codcar)
                    .HasColumnName("CODCAR")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eliminado)
                    .HasColumnName("ELIMINADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.Nomcar)
                    .IsRequired()
                    .HasColumnName("NOMCAR")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cursos>(entity =>
            {
                entity.HasKey(e => e.Codcur);

                entity.ToTable("CURSOS");

                entity.Property(e => e.Codcur)
                    .HasColumnName("CODCUR")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eliminado)
                    .HasColumnName("ELIMINADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.Nhoras)
                    .HasColumnName("NHORAS")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Nomcur)
                    .IsRequired()
                    .HasColumnName("NOMCUR")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notas>(entity =>
            {
                entity.HasKey(e => new { e.Codalu, e.Codcur });

                entity.ToTable("NOTAS");

                entity.Property(e => e.Codalu)
                    .HasColumnName("CODALU")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codcur)
                    .HasColumnName("CODCUR")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eliminado)
                    .HasColumnName("ELIMINADO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.Examen).HasColumnName("EXAMEN");

                entity.Property(e => e.Fecreg)
                    .HasColumnName("FECREG")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pract).HasColumnName("PRACT");

                entity.Property(e => e.Trab).HasColumnName("TRAB");

                entity.HasOne(d => d.CodaluNavigation)
                    .WithMany(p => p.Notas)
                    .HasForeignKey(d => d.Codalu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NOTAS_CODALU");

                entity.HasOne(d => d.CodcurNavigation)
                    .WithMany(p => p.Notas)
                    .HasForeignKey(d => d.Codcur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NOTAS_CODCUR");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
