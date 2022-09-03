﻿// <auto-generated />
using System;
using HappyTrip.Reservation.System.Repository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HappyTrip.Reservation.System.Repository.Migrations
{
    [DbContext(typeof(HappyTripContext))]
    partial class HappyTripContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HappyTrip.Reservation.System.Domain.Data.Entities.Bus", b =>
                {
                    b.Property<string>("BusNumber")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("BusType")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid>("DriverID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Lid")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("BusNumber");

                    b.ToTable("Buses");

                    b.HasData(
                        new
                        {
                            BusNumber = "FBC001",
                            BusType = 0,
                            Capacity = 40,
                            Company = "Five Star Bus Co.",
                            DriverID = new Guid("008daf97-f940-436d-9b84-14009f502190"),
                            Lid = 40,
                            Price = 100.0
                        },
                        new
                        {
                            BusNumber = "FBC002",
                            BusType = 1,
                            Capacity = 40,
                            Company = "Five Star Bus Co.",
                            DriverID = new Guid("f1a0b406-fc19-4060-b512-aa19e0b7b3f8"),
                            Lid = 40,
                            Price = 150.0
                        },
                        new
                        {
                            BusNumber = "FBC003",
                            BusType = 2,
                            Capacity = 30,
                            Company = "Five Star Bus Co.",
                            DriverID = new Guid("eb03863f-bd5e-4ad7-9ff7-eb8429780115"),
                            Lid = 30,
                            Price = 250.0
                        });
                });

            modelBuilder.Entity("HappyTrip.Reservation.System.Domain.Data.Entities.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = new Guid("8baf03f1-7911-4156-a650-24e747053557"),
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Katniss",
                            LastName = "Everdeen",
                            MiddleName = ""
                        },
                        new
                        {
                            CustomerID = new Guid("0d7fabcb-2fbc-4794-b46e-b8ed3c0e967a"),
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Primrose",
                            LastName = "Everdeen",
                            MiddleName = ""
                        },
                        new
                        {
                            CustomerID = new Guid("b637f251-9865-4fb6-bea8-6ccc742e9bf5"),
                            BirthDate = new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Peeta",
                            LastName = "Mellark",
                            MiddleName = ""
                        },
                        new
                        {
                            CustomerID = new Guid("ee54793f-e473-4ffa-921e-9559b6192e2a"),
                            BirthDate = new DateTime(2000, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Gale",
                            LastName = "Hawthorne",
                            MiddleName = ""
                        },
                        new
                        {
                            CustomerID = new Guid("9c9c20de-5d8e-4ee3-a15d-4bea24e98282"),
                            BirthDate = new DateTime(2000, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Haymitch",
                            LastName = "Abernathy",
                            MiddleName = ""
                        });
                });

            modelBuilder.Entity("HappyTrip.Reservation.System.Domain.Data.Entities.Driver", b =>
                {
                    b.Property<Guid>("DriverID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LicenseID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("DriverID");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            DriverID = new Guid("656e6136-e3d4-4710-a29a-42cf1ac4ab45"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Beatrice",
                            LastName = "Prior",
                            LicenseID = "NO1-12-123451",
                            MiddleName = ""
                        },
                        new
                        {
                            DriverID = new Guid("170938bd-8a23-4309-a916-7d462fd02a92"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Caleb",
                            LastName = "Prior",
                            LicenseID = "NO1-12-123452",
                            MiddleName = ""
                        },
                        new
                        {
                            DriverID = new Guid("78547904-10fe-4dfd-b455-1c337f22b6a4"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jeanine",
                            LastName = "Matthews",
                            LicenseID = "NO1-12-123453",
                            MiddleName = ""
                        });
                });

            modelBuilder.Entity("HappyTrip.Reservation.System.Domain.Data.Entities.StopOver", b =>
                {
                    b.Property<Guid>("TripID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<TimeSpan>("Period")
                        .HasColumnType("time");

                    b.Property<int>("Sequence")
                        .HasColumnType("int");

                    b.HasKey("TripID");

                    b.ToTable("StopOvers");

                    b.HasData(
                        new
                        {
                            TripID = new Guid("222fc3f5-dce8-45d6-8f77-d5365898ff81"),
                            Area = "SLEX",
                            Period = new TimeSpan(0, 0, 15, 0, 0),
                            Sequence = 1
                        },
                        new
                        {
                            TripID = new Guid("4b7ad05b-dded-48fe-9df3-4d1d554ab236"),
                            Area = "SLEX",
                            Period = new TimeSpan(0, 0, 15, 0, 0),
                            Sequence = 1
                        });
                });

            modelBuilder.Entity("HappyTrip.Reservation.System.Domain.Data.Entities.Terminal", b =>
                {
                    b.Property<Guid>("TerminalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TerminalID");

                    b.ToTable("Terminals");

                    b.HasData(
                        new
                        {
                            TerminalID = new Guid("d84b40df-15a2-4d27-a75a-1c874dfbeebc"),
                            Area = "Pasay, Metro Manila",
                            Company = "Five Star Bus Co."
                        },
                        new
                        {
                            TerminalID = new Guid("26bf7f0f-b351-43c1-8b1d-ce92cd2b8971"),
                            Area = "Five Star Bus Co.",
                            Company = "Pasay, Metro Manila"
                        });
                });

            modelBuilder.Entity("HappyTrip.Reservation.System.Domain.Data.Entities.Trip", b =>
                {
                    b.Property<Guid>("TripID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<string>("BusNumber")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TripID");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripID = new Guid("222fc3f5-dce8-45d6-8f77-d5365898ff81"),
                            Arrival = new DateTime(2022, 8, 22, 19, 15, 0, 0, DateTimeKind.Unspecified),
                            BusNumber = "FBC001",
                            Departure = new DateTime(2022, 8, 22, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Lucena, Quezon",
                            Origin = "Pasay, Metro Manila"
                        },
                        new
                        {
                            TripID = new Guid("4b7ad05b-dded-48fe-9df3-4d1d554ab236"),
                            Arrival = new DateTime(2022, 8, 22, 19, 15, 0, 0, DateTimeKind.Unspecified),
                            BusNumber = "FBC001",
                            Departure = new DateTime(2022, 8, 22, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Pasay, Metro Manila",
                            Origin = "Lucena, Quezon"
                        },
                        new
                        {
                            TripID = new Guid("5bc1d5d8-6907-470e-a725-ef0a7e863733"),
                            Arrival = new DateTime(2022, 8, 23, 19, 15, 0, 0, DateTimeKind.Unspecified),
                            BusNumber = "FBC002",
                            Departure = new DateTime(2022, 8, 23, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Lucena, Quezon",
                            Origin = "Pasay, Metro Manila"
                        },
                        new
                        {
                            TripID = new Guid("99e50980-a5a9-4f43-a3c6-95a7a31a769d"),
                            Arrival = new DateTime(2022, 8, 23, 19, 15, 0, 0, DateTimeKind.Unspecified),
                            BusNumber = "FBC002",
                            Departure = new DateTime(2022, 8, 23, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Pasay, Metro Manila",
                            Origin = "Lucena, Quezon"
                        },
                        new
                        {
                            TripID = new Guid("3cfb040b-7295-4d8e-b673-c251100e28f5"),
                            Arrival = new DateTime(2022, 8, 24, 19, 15, 0, 0, DateTimeKind.Unspecified),
                            BusNumber = "FBC003",
                            Departure = new DateTime(2022, 8, 24, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Lucena, Quezon",
                            Origin = "Pasay, Metro Manila"
                        },
                        new
                        {
                            TripID = new Guid("c280b0c3-82a6-408a-8596-b07940cac28a"),
                            Arrival = new DateTime(2022, 8, 24, 19, 15, 0, 0, DateTimeKind.Unspecified),
                            BusNumber = "FBC003",
                            Departure = new DateTime(2022, 8, 24, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Destination = "Pasay, Metro Manila",
                            Origin = "Lucena, Quezon"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
