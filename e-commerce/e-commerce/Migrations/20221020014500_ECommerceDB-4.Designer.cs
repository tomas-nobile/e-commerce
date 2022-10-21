﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using e_commerce;

namespace e_commerce.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20221020014500_ECommerceDB-4")]
    partial class ECommerceDB4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("e_commerce.CarritoDeCompras", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("productoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productoid");

                    b.ToTable("CarritoDeCompras");
                });

            modelBuilder.Entity("e_commerce.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Usuarioid")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("Usuarioid");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("e_commerce.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("carritoid")
                        .HasColumnType("int");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefono")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("carritoid");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("e_commerce.CarritoDeCompras", b =>
                {
                    b.HasOne("e_commerce.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("productoid");
                });

            modelBuilder.Entity("e_commerce.Producto", b =>
                {
                    b.HasOne("e_commerce.Usuario", null)
                        .WithMany("productos")
                        .HasForeignKey("Usuarioid");
                });

            modelBuilder.Entity("e_commerce.Usuario", b =>
                {
                    b.HasOne("e_commerce.CarritoDeCompras", "carrito")
                        .WithMany()
                        .HasForeignKey("carritoid");
                });
#pragma warning restore 612, 618
        }
    }
}
