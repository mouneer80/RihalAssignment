﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RihalAssignment.Api.Models;

namespace RihalAssignment.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211207162007_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("RihalAssignment.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Grade 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Grade 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Grade 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Grade 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Grade 5"
                        });
                });

            modelBuilder.Entity("RihalAssignment.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "El Salvador"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bouvet Island"
                        },
                        new
                        {
                            Id = 3,
                            Name = "South Sudan"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Croatia"
                        });
                });

            modelBuilder.Entity("RihalAssignment.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("CountryId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassId = 4,
                            CountryId = 1,
                            DateOfBirth = new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mr. Casimer Olson"
                        },
                        new
                        {
                            Id = 2,
                            ClassId = 3,
                            CountryId = 4,
                            DateOfBirth = new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Audrey Kutch Sr."
                        },
                        new
                        {
                            Id = 3,
                            ClassId = 5,
                            CountryId = 1,
                            DateOfBirth = new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Janelle VonRueden DDS"
                        },
                        new
                        {
                            Id = 4,
                            ClassId = 3,
                            CountryId = 2,
                            DateOfBirth = new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prof. Jeremie Eudora Zboncak"
                        },
                        new
                        {
                            Id = 5,
                            ClassId = 3,
                            CountryId = 1,
                            DateOfBirth = new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Devon Renner"
                        },
                        new
                        {
                            Id = 6,
                            ClassId = 3,
                            CountryId = 2,
                            DateOfBirth = new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rey Pollich"
                        },
                        new
                        {
                            Id = 7,
                            ClassId = 1,
                            CountryId = 4,
                            DateOfBirth = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sigurd McGlynn"
                        },
                        new
                        {
                            Id = 8,
                            ClassId = 1,
                            CountryId = 4,
                            DateOfBirth = new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prof. Aurore Medhurst DVM"
                        },
                        new
                        {
                            Id = 9,
                            ClassId = 5,
                            CountryId = 4,
                            DateOfBirth = new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Hertha Cormier"
                        },
                        new
                        {
                            Id = 10,
                            ClassId = 3,
                            CountryId = 2,
                            DateOfBirth = new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mrs. Destini Ramona Bosco"
                        });
                });

            modelBuilder.Entity("RihalAssignment.Models.Student", b =>
                {
                    b.HasOne("RihalAssignment.Models.Class", "Classes")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RihalAssignment.Models.Country", "Countries")
                        .WithMany("Students")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classes");

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("RihalAssignment.Models.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("RihalAssignment.Models.Country", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
