﻿// <auto-generated />
using System;
using IzhCoil_Timetable.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IzhCloud_Timetable.Migrations
{
    [DbContext(typeof(EFDBContext))]
    [Migration("20200207114258_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IzhCloud_Timetable.Models.Entities.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstSecond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FourthFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FourthSecond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondSecond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdSecond")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}
