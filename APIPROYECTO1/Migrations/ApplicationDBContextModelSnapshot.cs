﻿// <auto-generated />
using APIPROYECTO1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIPROYECTO1.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIPROYECTO1.Models.Accesorios", b =>
                {
                    b.Property<int>("IdAccesorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAccesorio"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.HasKey("IdAccesorio");

                    b.ToTable("Accesorios");

                    b.HasData(
                        new
                        {
                            IdAccesorio = 1,
                            Cantidad = 2,
                            Descripcion = "Collar blanco de plata",
                            Marca = "cartier",
                            Nombre = "Collar",
                            Precio = 11f
                        },
                        new
                        {
                            IdAccesorio = 2,
                            Cantidad = 3,
                            Descripcion = "Aretes largos",
                            Marca = "buccellati",
                            Nombre = "Aretes",
                            Precio = 20f
                        });
                });

            modelBuilder.Entity("APIPROYECTO1.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("APIPROYECTO1.Models.Marca", b =>
                {
                    b.Property<int>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMarca"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMarca");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("APIPROYECTO1.Models.Prenda", b =>
                {
                    b.Property<int>("IdPrenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrenda"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.HasKey("IdPrenda");

                    b.ToTable("Prendas");

                    b.HasData(
                        new
                        {
                            IdPrenda = 1,
                            Cantidad = 2,
                            Categoria = "Deportivo",
                            Descripcion = "Pantalon",
                            Marca = "zara",
                            Nombre = "prenda1",
                            Precio = 40f
                        },
                        new
                        {
                            IdPrenda = 2,
                            Cantidad = 3,
                            Categoria = "Casual",
                            Descripcion = "falda",
                            Marca = "zara",
                            Nombre = "prenda2",
                            Precio = 20f
                        });
                });

            modelBuilder.Entity("APIPROYECTO1.Models.Promocion", b =>
                {
                    b.Property<int>("IdPromocion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPromocion"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.HasKey("IdPromocion");

                    b.ToTable("promociones");

                    b.HasData(
                        new
                        {
                            IdPromocion = 1,
                            Cantidad = 2,
                            Descripcion = "Blusa azul",
                            Marca = "shein",
                            Nombre = "Promocion 1",
                            Precio = 13f
                        },
                        new
                        {
                            IdPromocion = 2,
                            Cantidad = 3,
                            Descripcion = "Aretes largos",
                            Marca = "shein",
                            Nombre = "Promocion 2",
                            Precio = 15f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
