﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240125130212_MadeProduseNullableInComenzi")]
    partial class MadeProduseNullableInComenzi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("backend.Models.Comanda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Favorita")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UtilizatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UtilizatorId");

                    b.ToTable("Comenzi");
                });

            modelBuilder.Entity("backend.Models.ComandaProdusRelatie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ComandaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ProdusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ComandaId");

                    b.HasIndex("ProdusId");

                    b.ToTable("ComandaProdusRelatii");
                });

            modelBuilder.Entity("backend.Models.Produs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pret")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("backend.Models.Utilizator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilizatori");
                });

            modelBuilder.Entity("backend.Models.Comanda", b =>
                {
                    b.HasOne("backend.Models.Utilizator", "Utilizator")
                        .WithMany("Comenzi")
                        .HasForeignKey("UtilizatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizator");
                });

            modelBuilder.Entity("backend.Models.ComandaProdusRelatie", b =>
                {
                    b.HasOne("backend.Models.Comanda", "Comanda")
                        .WithMany("Produse")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("backend.Models.Produs", "Produs")
                        .WithMany("Comenzi")
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Comanda");

                    b.Navigation("Produs");
                });

            modelBuilder.Entity("backend.Models.Comanda", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("backend.Models.Produs", b =>
                {
                    b.Navigation("Comenzi");
                });

            modelBuilder.Entity("backend.Models.Utilizator", b =>
                {
                    b.Navigation("Comenzi");
                });
#pragma warning restore 612, 618
        }
    }
}
