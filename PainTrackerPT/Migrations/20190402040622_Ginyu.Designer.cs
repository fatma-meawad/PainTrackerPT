﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PainTrackerPT.Models;

namespace PainTrackerPT.Migrations
{
    [DbContext(typeof(PainTrackerPTContext))]
    [Migration("20190402040622_Ginyu")]
    partial class Ginyu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.GFPatient.Interference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnName("Date");

                    b.Property<string>("Description")
                        .HasColumnName("Description");

                    b.Property<int>("Duration")
                        .HasColumnName("Duration");

                    b.Property<int>("PainDiaryID");

                    b.Property<int>("Severity")
                        .HasColumnName("Severity");

                    b.HasKey("Id");

                    b.HasIndex("PainDiaryID");

                    b.ToTable("Interference");
                });

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.GFPatient.Mood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnName("Date");

                    b.Property<int>("Duration")
                        .HasColumnName("Duration");

                    b.Property<int>("MoodType")
                        .HasColumnName("MoodType");

                    b.Property<int>("PainDiaryID");

                    b.HasKey("Id");

                    b.HasIndex("PainDiaryID");

                    b.ToTable("Mood");
                });

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.GFPatient.PainDiary", b =>
                {
                    b.Property<int>("PainDiaryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PatientID");

                    b.HasKey("PainDiaryID");

                    b.ToTable("PainDiary");
                });

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.GFPatient.PainIntensity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnName("Date");

                    b.Property<int>("Duration")
                        .HasColumnName("Duration");

                    b.Property<int>("PainArea")
                        .HasColumnName("PainArea");

                    b.Property<int>("PainDiaryID");

                    b.Property<int>("PainRating")
                        .HasColumnName("PainRating");

                    b.HasKey("Id");

                    b.HasIndex("PainDiaryID");

                    b.ToTable("PainIntensity");
                });

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.GFPatient.Sleep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComfortLevel")
                        .HasColumnName("ComfortLevel");

                    b.Property<DateTime>("Date")
                        .HasColumnName("Date");

                    b.Property<int>("PainDiaryID");

                    b.Property<int>("SleepHours")
                        .HasColumnName("SleepHours");

                    b.Property<int>("Tiredness")
                        .HasColumnName("Tiredness");

                    b.HasKey("Id");

                    b.HasIndex("PainDiaryID");

                    b.ToTable("Sleep");
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

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.GFPatient.Interference", b =>
                {
                    b.HasOne("PainTrackerPT.Models.Analytics.GFPatient.PainDiary")
                        .WithMany("Interference")
                        .HasForeignKey("PainDiaryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.GFPatient.Mood", b =>
                {
                    b.HasOne("PainTrackerPT.Models.Analytics.GFPatient.PainDiary")
                        .WithMany("Mood")
                        .HasForeignKey("PainDiaryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.GFPatient.PainIntensity", b =>
                {
                    b.HasOne("PainTrackerPT.Models.Analytics.GFPatient.PainDiary")
                        .WithMany("PainIntensity")
                        .HasForeignKey("PainDiaryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PainTrackerPT.Models.Analytics.GFPatient.Sleep", b =>
                {
                    b.HasOne("PainTrackerPT.Models.Analytics.GFPatient.PainDiary")
                        .WithMany("Sleep")
                        .HasForeignKey("PainDiaryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}