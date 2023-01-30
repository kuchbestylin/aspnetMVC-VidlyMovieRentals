﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vidly.Data;

#nullable disable

namespace Vidly.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230126102806_addingGenreIdSeedAndGenreRelationToMovie")]
    partial class addingGenreIdSeedAndGenreRelationToMovie
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSubscribedToNewsLetter")
                        .HasColumnType("bit");

                    b.Property<int>("MembershipTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("MembershipTypeId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Vidly.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Scify"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("Vidly.Models.MembershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("DiscountRate")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DurationInMonths")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("SignUpFee")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MembershipTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountRate = (byte)0,
                            DurationInMonths = (byte)0,
                            Name = "Free",
                            SignUpFee = (short)0
                        },
                        new
                        {
                            Id = 2,
                            DiscountRate = (byte)10,
                            DurationInMonths = (byte)1,
                            Name = "Basic",
                            SignUpFee = (short)30
                        },
                        new
                        {
                            Id = 3,
                            DiscountRate = (byte)15,
                            DurationInMonths = (byte)3,
                            Name = "Compact",
                            SignUpFee = (short)90
                        },
                        new
                        {
                            Id = 4,
                            DiscountRate = (byte)20,
                            DurationInMonths = (byte)12,
                            Name = "Premium",
                            SignUpFee = (short)300
                        });
                });

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Added")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Release")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Added = new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7320),
                            GenreId = 5,
                            Name = "A Perfect Match",
                            Release = new DateTime(2016, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 5
                        },
                        new
                        {
                            Id = 2,
                            Added = new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7361),
                            GenreId = 2,
                            Name = "Jumanji",
                            Release = new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 4
                        },
                        new
                        {
                            Id = 3,
                            Added = new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7376),
                            GenreId = 6,
                            Name = "A Resonable Doubt",
                            Release = new DateTime(2013, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 55
                        },
                        new
                        {
                            Id = 4,
                            Added = new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7391),
                            GenreId = 6,
                            Name = "Brown Coffee",
                            Release = new DateTime(2013, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 6
                        },
                        new
                        {
                            Id = 5,
                            Added = new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7405),
                            GenreId = 1,
                            Name = "Most Wanted",
                            Release = new DateTime(2016, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 18
                        },
                        new
                        {
                            Id = 6,
                            Added = new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7421),
                            GenreId = 5,
                            Name = "The Maze Runner",
                            Release = new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 34
                        },
                        new
                        {
                            Id = 7,
                            Added = new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7435),
                            GenreId = 7,
                            Name = "Blade Runner",
                            Release = new DateTime(2017, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 68
                        },
                        new
                        {
                            Id = 8,
                            Added = new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7449),
                            GenreId = 1,
                            Name = "13 Hours the Secret Soldier",
                            Release = new DateTime(2012, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 6
                        },
                        new
                        {
                            Id = 9,
                            Added = new DateTime(2023, 1, 26, 12, 28, 5, 766, DateTimeKind.Local).AddTicks(7463),
                            GenreId = 1,
                            Name = "The Matrix Ressurection",
                            Release = new DateTime(1994, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 3
                        });
                });

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.HasOne("Vidly.Models.MembershipType", "MembershipType")
                        .WithMany()
                        .HasForeignKey("MembershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipType");
                });

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.HasOne("Vidly.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
