﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreCampsAPI.Data;

namespace NetCoreCampsAPI.Migrations
{
    [DbContext(typeof(CampDBContext))]
    partial class CampDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCoreCampsAPI.Models.Camp", b =>
                {
                    b.Property<int>("CampId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Moniker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CampId");

                    b.HasIndex("LocationId");

                    b.ToTable("Camps");

                    b.HasData(
                        new
                        {
                            CampId = 1,
                            EventDate = new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Length = 1,
                            LocationId = 1,
                            Moniker = "ATL2018",
                            Name = "Atlanta Code Camp"
                        });
                });

            modelBuilder.Entity("NetCoreCampsAPI.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Address1 = "123 Main Street",
                            CityTown = "Atlanta",
                            Country = "USA",
                            PostalCode = "12345",
                            StateProvince = "GA",
                            VenueName = "Atlanta Convention Center"
                        });
                });

            modelBuilder.Entity("NetCoreCampsAPI.Models.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GitHub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpeakerId");

                    b.ToTable("Speakers");

                    b.HasData(
                        new
                        {
                            SpeakerId = 1,
                            BlogUrl = "http://github.com",
                            Company = "We N Us",
                            CompanyUrl = "http://smp.com",
                            FirstName = "Mani",
                            GitHub = "smp0104",
                            LastName = "S",
                            Twitter = "smp0104"
                        },
                        new
                        {
                            SpeakerId = 2,
                            BlogUrl = "http://shawnandresa.com",
                            Company = "We N Us",
                            CompanyUrl = "http://smp.com",
                            FirstName = "SMP",
                            GitHub = "smp0104",
                            LastName = "Kumar",
                            Twitter = "smp0104"
                        });
                });

            modelBuilder.Entity("NetCoreCampsAPI.Models.Talk", b =>
                {
                    b.Property<int>("TalkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abstract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CampId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("SpeakerId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TalkId");

                    b.HasIndex("CampId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("Talks");

                    b.HasData(
                        new
                        {
                            TalkId = 1,
                            Abstract = "Entity Framework from scratch in an hour. Probably cover it all",
                            CampId = 1,
                            Level = 100,
                            SpeakerId = 1,
                            Title = "Entity Framework From Scratch"
                        },
                        new
                        {
                            TalkId = 2,
                            Abstract = "Thinking of good sample data examples is tiring.",
                            CampId = 1,
                            Level = 200,
                            SpeakerId = 2,
                            Title = "Writing Sample Data Made Easy"
                        });
                });

            modelBuilder.Entity("NetCoreCampsAPI.Models.Camp", b =>
                {
                    b.HasOne("NetCoreCampsAPI.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("NetCoreCampsAPI.Models.Talk", b =>
                {
                    b.HasOne("NetCoreCampsAPI.Models.Camp", "Camp")
                        .WithMany("Talks")
                        .HasForeignKey("CampId");

                    b.HasOne("NetCoreCampsAPI.Models.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerId");
                });
#pragma warning restore 612, 618
        }
    }
}
