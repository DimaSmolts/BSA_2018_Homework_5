﻿// <auto-generated />
using BSA_2018_Homework_4.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BSA_2018_Homework_4.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Crew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PilotIdId");

                    b.HasKey("Id");

                    b.HasIndex("PilotIdId");

                    b.ToTable("Crew");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArrivalPlace");

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<string>("DeperturePlace");

                    b.HasKey("FlightId");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birth");

                    b.Property<TimeSpan>("Experience");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Pilot");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Plane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<TimeSpan>("Exploitation");

                    b.Property<DateTime>("Made");

                    b.Property<string>("Name");

                    b.Property<int?>("PlaneTypeId");

                    b.HasKey("Id");

                    b.HasIndex("PlaneTypeId");

                    b.ToTable("PLane");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.PlaneType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarryCapacity");

                    b.Property<string>("Model");

                    b.Property<int>("Places");

                    b.HasKey("Id");

                    b.ToTable("PlaneType");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Stewardess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birth");

                    b.Property<int?>("CrewId");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("CrewId");

                    b.ToTable("Stewardess");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.TakeOff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CrewIdId");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("FlightNumFlightId");

                    b.Property<int?>("PlaneIdId");

                    b.HasKey("Id");

                    b.HasIndex("CrewIdId");

                    b.HasIndex("FlightNumFlightId");

                    b.HasIndex("PlaneIdId");

                    b.ToTable("TakeOff");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FlightId");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Crew", b =>
                {
                    b.HasOne("BSA_2018_Homework_4.DAL.Models.Pilot", "PilotId")
                        .WithMany()
                        .HasForeignKey("PilotIdId");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Plane", b =>
                {
                    b.HasOne("BSA_2018_Homework_4.DAL.Models.PlaneType")
                        .WithMany("Plane")
                        .HasForeignKey("PlaneTypeId");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Stewardess", b =>
                {
                    b.HasOne("BSA_2018_Homework_4.DAL.Models.Crew")
                        .WithMany("StewardessIds")
                        .HasForeignKey("CrewId");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.TakeOff", b =>
                {
                    b.HasOne("BSA_2018_Homework_4.DAL.Models.Crew", "CrewId")
                        .WithMany()
                        .HasForeignKey("CrewIdId");

                    b.HasOne("BSA_2018_Homework_4.DAL.Models.Flight", "FlightNum")
                        .WithMany()
                        .HasForeignKey("FlightNumFlightId");

                    b.HasOne("BSA_2018_Homework_4.DAL.Models.Plane", "PlaneId")
                        .WithMany()
                        .HasForeignKey("PlaneIdId");
                });

            modelBuilder.Entity("BSA_2018_Homework_4.DAL.Models.Ticket", b =>
                {
                    b.HasOne("BSA_2018_Homework_4.DAL.Models.Flight")
                        .WithMany("TicketId")
                        .HasForeignKey("FlightId");
                });
#pragma warning restore 612, 618
        }
    }
}
