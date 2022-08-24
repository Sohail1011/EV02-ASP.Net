﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EV02.Models
{
    public partial class Neptuno2020Context : DbContext
    {
        public Neptuno2020Context()
        {
        }

        public Neptuno2020Context(DbContextOptions<Neptuno2020Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<CompañiasEnvios> CompañiasEnvios { get; set; }
        public virtual DbSet<DetallesPedidos> DetallesPedidos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<EmpleadosTerritorios> EmpleadosTerritorios { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Territorios> Territorios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=Neptuno2020;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.IdCategoria).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.NombreCategoria)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CargoContacto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreContacto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompañiasEnvios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Compañias_Envios");

                entity.Property(e => e.NombreCompañia)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetallesPedidos>(entity =>
            {
                entity.HasKey(e => new { e.IdPedido, e.IdProducto });

                entity.ToTable("Detalles_Pedidos");

                entity.Property(e => e.Descuento).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.PrecioUnidad).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.DetallesPedidos)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalles_Pedidos_Pedidos");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetallesPedidos)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalles_Pedidos_Productos");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.Property(e => e.IdEmpleado).ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaContratacion).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notas).IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TelDomicilio)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpleadosTerritorios>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpleado, e.IdTerritorio });

                entity.Property(e => e.IdTerritorio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.EmpleadosTerritorios)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeTerritorios_Employees");

                entity.HasOne(d => d.IdTerritorioNavigation)
                    .WithMany(p => p.EmpleadosTerritorios)
                    .HasForeignKey(d => d.IdTerritorio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpleadosTerritorios_Territorios");
            });

            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.Property(e => e.IdPedido).ValueGeneratedNever();

                entity.Property(e => e.Cargo).HasColumnType("money");

                entity.Property(e => e.CiudadDestinatario)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodPostalDestinatario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Destinatario)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionDestinatario)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.FechaPedido).HasColumnType("datetime");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDestinatario)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RegionDestinatario)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedidos_Clientes");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("FK_Pedidos_Empleados");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.Property(e => e.IdProducto).ValueGeneratedNever();

                entity.Property(e => e.CantidadPorUnidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioUnidad).HasColumnType("money");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_Productos_Categorias");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_Productos_Proveedores");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.Property(e => e.IdProveedor).ValueGeneratedNever();

                entity.Property(e => e.CargoContacto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NombreContacto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PaginaPrincipal).IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.IdRegion);

                entity.Property(e => e.IdRegion).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Territorios>(entity =>
            {
                entity.HasKey(e => e.IdTerritorio);

                entity.Property(e => e.IdTerritorio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.Territorios)
                    .HasForeignKey(d => d.IdRegion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Territorios_Region");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
