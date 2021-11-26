﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mountaineering.Database;

namespace Mountaineering.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211126110435_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("Mountaineering.Models.Climber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Altitude")
                        .HasColumnType("int");

                    b.Property<string>("Climbers_Name")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsInjured")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Mountain_Id")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Mountain_Id");

                    b.ToTable("ClimberTable");
                });

            modelBuilder.Entity("Mountaineering.Models.Mountain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstAscent")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Mountain_Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MountainTable");
                });

            modelBuilder.Entity("Mountaineering.Models.Climber", b =>
                {
                    b.HasOne("Mountaineering.Models.Mountain", "Mountain")
                        .WithMany("Climbers")
                        .HasForeignKey("Mountain_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mountain");
                });

            modelBuilder.Entity("Mountaineering.Models.Mountain", b =>
                {
                    b.Navigation("Climbers");
                });
#pragma warning restore 612, 618
        }
    }
}
