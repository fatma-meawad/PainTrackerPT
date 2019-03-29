﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PainTrackerPT.Models;

namespace PainTrackerPT.Migrations
{
    [DbContext(typeof(PainTrackerPTContext))]
    partial class PainTrackerPTContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.AnalyticsLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("timeStamp");

                    b.HasKey("Id");

                    b.ToTable("AnalyticsLog");
                });

            modelBuilder.Entity("PainTrackerPT.Models.Doctors.DoctorsLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("timeStamp");

                    b.HasKey("Id");

                    b.ToTable("DoctorsLog");
                });

            modelBuilder.Entity("PainTrackerPT.Models.Doctors.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAdd")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Pin")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PainTrackerPT.Models.Events.EventsLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("timeStamp");

                    b.HasKey("Id");

                    b.ToTable("EventsLog");
                });

            modelBuilder.Entity("PainTrackerPT.Models.Followups.FollowupsLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("timeStamp");

                    b.HasKey("Id");

                    b.ToTable("FollowupsLog");
                });

            modelBuilder.Entity("PainTrackerPT.Models.Medicine.MedicineLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("timeStamp");

                    b.HasKey("Id");

                    b.ToTable("MedicineLog");
                });

            modelBuilder.Entity("PainTrackerPT.Models.PainDiary.PainDiaryLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("timeStamp");

                    b.HasKey("Id");

                    b.ToTable("PainDiaryLog");
                });
#pragma warning restore 612, 618
        }
    }
}
