﻿// <auto-generated />
using System;
using EF_Example;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Example.Migrations
{
    [DbContext(typeof(ExampleDbContext))]
    [Migration("20230319193859_AddISBNString")]
    partial class AddISBNString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_Example.Models.Books", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Book_Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Catergory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("Books", (string)null);
                });

            modelBuilder.Entity("EF_Example.Models.UserData", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Book_Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<long>("User_id")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("UserData", (string)null);
                });

            modelBuilder.Entity("EF_Example.Models.UserLogin", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("Login_date")
                        .HasColumnType("date");

                    b.Property<string>("Password")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("User_Role")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int")
                        .HasDefaultValue(3);

                    b.Property<string>("User_name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("UserLogin", (string)null);
                });

            modelBuilder.Entity("EF_Example.Models.UseRole", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Role_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("User_Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 0,
                            Role_Name = "Banned"
                        },
                        new
                        {
                            Id = 1,
                            Role_Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Role_Name = "Logistic"
                        },
                        new
                        {
                            Id = 3,
                            Role_Name = "User"
                        },
                        new
                        {
                            Id = 4,
                            Role_Name = "ManageLogistic"
                        },
                        new
                        {
                            Id = 5,
                            Role_Name = "Director"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
