﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RestaurantModels;

namespace RestaurantModels.Migrations
{
    [DbContext(typeof(RestaurantDbContext))]
    [Migration("20200426155329_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RestaurantModels.Models.Executant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Salary")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Executants");
                });

            modelBuilder.Entity("RestaurantModels.Models.Export", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ExportDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Exports");
                });

            modelBuilder.Entity("RestaurantModels.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ExportId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ExportId");

                    b.HasIndex("OrderId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("RestaurantModels.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("MessageText")
                        .HasColumnType("text");

                    b.Property<int>("ReceiveId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("RestaurantModels.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EndOrder")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("ExportId")
                        .HasColumnType("integer");

                    b.Property<int?>("TableId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TimeOrder")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ExportId");

                    b.HasIndex("TableId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RestaurantModels.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ItemsId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Prices")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("RestaurantModels.Models.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Star")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("RestaurantModels.Models.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("RestaurantModels.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("PositionX")
                        .HasColumnType("integer");

                    b.Property<int>("PositionY")
                        .HasColumnType("integer");

                    b.Property<int?>("RateId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RateId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("RestaurantModels.Models.TaskModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ExprireDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ReceiveId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.Property<string>("TaskText")
                        .HasColumnType("text");

                    b.Property<string>("Themes")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("TaskModels");
                });

            modelBuilder.Entity("RestaurantModels.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RestaurantModels.Models.Menu", b =>
                {
                    b.HasOne("RestaurantModels.Models.Export", null)
                        .WithMany("Menu")
                        .HasForeignKey("ExportId");

                    b.HasOne("RestaurantModels.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("RestaurantModels.Models.Order", b =>
                {
                    b.HasOne("RestaurantModels.Models.Export", null)
                        .WithMany("Order")
                        .HasForeignKey("ExportId");

                    b.HasOne("RestaurantModels.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId");
                });

            modelBuilder.Entity("RestaurantModels.Models.Rule", b =>
                {
                    b.HasOne("RestaurantModels.Models.User", null)
                        .WithMany("Rules")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RestaurantModels.Models.Table", b =>
                {
                    b.HasOne("RestaurantModels.Models.Rate", "Rate")
                        .WithMany()
                        .HasForeignKey("RateId");
                });
#pragma warning restore 612, 618
        }
    }
}