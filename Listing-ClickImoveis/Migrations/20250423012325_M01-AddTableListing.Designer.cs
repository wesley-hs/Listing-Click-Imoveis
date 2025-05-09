﻿// <auto-generated />
using System;
using Listing_ClickImoveis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Listing_ClickImoveis.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250423012325_M01-AddTableListing")]
    partial class M01AddTableListing
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Listing_ClickImoveis.Models.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Area")
                        .HasColumnType("float");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereço")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preço")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoAnuncio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Título")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Listing");
                });

            modelBuilder.Entity("Listing_ClickImoveis.Models.Midia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.ToTable("Midia");
                });

            modelBuilder.Entity("Listing_ClickImoveis.Models.Midia", b =>
                {
                    b.HasOne("Listing_ClickImoveis.Models.Listing", "Listing")
                        .WithMany("Midias")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("Listing_ClickImoveis.Models.Listing", b =>
                {
                    b.Navigation("Midias");
                });
#pragma warning restore 612, 618
        }
    }
}
