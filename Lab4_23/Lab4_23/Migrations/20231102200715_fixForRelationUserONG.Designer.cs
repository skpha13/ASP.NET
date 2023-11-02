﻿// <auto-generated />
using System;
using Lab4_23.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab4_23.Migrations
{
    [DbContext(typeof(Lab4Context))]
    [Migration("20231102200715_fixForRelationUserONG")]
    partial class fixForRelationUserONG
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab4_23.Models.Need", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Needs");
                });

            modelBuilder.Entity("Lab4_23.Models.ONG", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ONGS");
                });

            modelBuilder.Entity("Lab4_23.Models.ONGHasPosts", b =>
                {
                    b.Property<Guid>("ONGId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.HasKey("ONGId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("ONGHasPostsRelation");
                });

            modelBuilder.Entity("Lab4_23.Models.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Lab4_23.Models.PostHasNeeds", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NeedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.HasKey("PostId", "NeedId");

                    b.HasIndex("NeedId");

                    b.ToTable("PostHasNeedsRelation");
                });

            modelBuilder.Entity("Lab4_23.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberStars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Lab4_23.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ONGId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Lab4_23.Models.ONGHasPosts", b =>
                {
                    b.HasOne("Lab4_23.Models.Post", "Post")
                        .WithMany("HasONG")
                        .HasForeignKey("ONGId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab4_23.Models.ONG", "ONG")
                        .WithMany("HasPosts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ONG");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Lab4_23.Models.PostHasNeeds", b =>
                {
                    b.HasOne("Lab4_23.Models.Need", "Need")
                        .WithMany("HasPosts")
                        .HasForeignKey("NeedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab4_23.Models.Post", "Post")
                        .WithMany("HasNeeds")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Need");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Lab4_23.Models.Review", b =>
                {
                    b.HasOne("Lab4_23.Models.Post", "Post")
                        .WithMany("Reviews")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Lab4_23.Models.User", b =>
                {
                    b.HasOne("Lab4_23.Models.ONG", "ONG")
                        .WithOne("User")
                        .HasForeignKey("Lab4_23.Models.User", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ONG");
                });

            modelBuilder.Entity("Lab4_23.Models.Need", b =>
                {
                    b.Navigation("HasPosts");
                });

            modelBuilder.Entity("Lab4_23.Models.ONG", b =>
                {
                    b.Navigation("HasPosts");

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Lab4_23.Models.Post", b =>
                {
                    b.Navigation("HasNeeds");

                    b.Navigation("HasONG");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
