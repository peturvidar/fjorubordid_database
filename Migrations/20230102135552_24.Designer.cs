﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fjorubordid_database.Data;

#nullable disable

namespace fjorubordiddatabase.Migrations
{
    [DbContext(typeof(FjorubordidDbContext))]
    [Migration("20230102135552_24")]
    partial class _24
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d138a5a6-7832-491c-a193-3aa8c71b4fa8",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "81fcd48e-9d27-47b4-8d5f-ca930ea43451",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("fjorubordid_database.Data.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("OwnerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("fjorubordid_database.Models.Drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrinkId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("DrinkId");

                    b.HasIndex("OrderItemId");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            DrinkId = 1,
                            Description = "Egils Gull 0.5l",
                            Name = "Egils Gull 0.5l",
                            Quantity = 1,
                            UnitPrice = 1400
                        },
                        new
                        {
                            DrinkId = 2,
                            Description = "Egils Gull 0.3l",
                            Name = "Egils Gull 0.3l",
                            Quantity = 1,
                            UnitPrice = 1200
                        },
                        new
                        {
                            DrinkId = 3,
                            Description = "Flaska af hvítvíni hússins",
                            Name = "Hvítvín hússins",
                            Quantity = 1,
                            UnitPrice = 7200
                        },
                        new
                        {
                            DrinkId = 4,
                            Description = "Flaska af rauðvíni hússins",
                            Name = "Rauðvín hússins",
                            Quantity = 1,
                            UnitPrice = 7200
                        },
                        new
                        {
                            DrinkId = 5,
                            Description = "Pepsi í gleri 330ml",
                            Name = "Pepsi",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 6,
                            Description = "Pepsi í gleri 330ml",
                            Name = "Pepsi Max",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 7,
                            Description = "7up í gleri 330ml",
                            Name = "7up",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 8,
                            Description = "Appelsín í gleri 330ml",
                            Name = "Appelsín",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 9,
                            Description = "Kristall í gleri 330ml án bragðefna",
                            Name = "Kristall",
                            Quantity = 1,
                            UnitPrice = 500
                        },
                        new
                        {
                            DrinkId = 10,
                            Description = "Sleipnir Pale Ale frá Ölvisholt Brugghús 330ml",
                            Name = "Sleipnir Pale Ale",
                            Quantity = 1,
                            UnitPrice = 1600
                        });
                });

            modelBuilder.Entity("fjorubordid_database.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("FoodId");

                    b.HasIndex("OrderItemId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            Description = "3ja rétta 400g",
                            Name = "3ja rétta 400g",
                            Quantity = 1,
                            UnitPrice = 14175
                        },
                        new
                        {
                            FoodId = 2,
                            Description = "3ja rétta 300g",
                            Name = "3ja rétta 300g",
                            Quantity = 1,
                            UnitPrice = 12250
                        },
                        new
                        {
                            FoodId = 3,
                            Description = "Leturhumar 400g",
                            Name = "Humar 400g",
                            Quantity = 1,
                            UnitPrice = 10750
                        },
                        new
                        {
                            FoodId = 4,
                            Description = "Leturhumar 300g",
                            Name = "Humar 300g",
                            Quantity = 1,
                            UnitPrice = 8650
                        },
                        new
                        {
                            FoodId = 5,
                            Description = "Leturhumar 250g",
                            Name = "Humar 250g",
                            Quantity = 1,
                            UnitPrice = 8050
                        },
                        new
                        {
                            FoodId = 6,
                            Description = "Aðalréttur",
                            Name = "Humarsúpa",
                            Quantity = 1,
                            UnitPrice = 4190
                        },
                        new
                        {
                            FoodId = 7,
                            Description = "Forréttur",
                            Name = "Humarsúpa",
                            Quantity = 1,
                            UnitPrice = 3250
                        },
                        new
                        {
                            FoodId = 8,
                            Description = "Grænmetisréttur",
                            Name = "Grænmetisréttur",
                            Quantity = 1,
                            UnitPrice = 4190
                        },
                        new
                        {
                            FoodId = 9,
                            Description = "Lambahryggvöðvi",
                            Name = "Lambahryggvöðvi",
                            Quantity = 1,
                            UnitPrice = 6250
                        },
                        new
                        {
                            FoodId = 10,
                            Description = "Barnamatseðill",
                            Name = "Kjúklinganaggar",
                            Quantity = 1,
                            UnitPrice = 990
                        },
                        new
                        {
                            FoodId = 11,
                            Description = "Barnamatseðill",
                            Name = "Samloka",
                            Quantity = 1,
                            UnitPrice = 990
                        },
                        new
                        {
                            FoodId = 12,
                            Description = "Eftirréttur tertusneið",
                            Name = "Eftirréttur",
                            Quantity = 1,
                            UnitPrice = 1650
                        });
                });

            modelBuilder.Entity("fjorubordid_database.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DrinkId")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderItemId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("fjorubordid_database.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("fjorubordid_database.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fjorubordid_database.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("fjorubordid_database.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fjorubordid_database.Models.Drink", b =>
                {
                    b.HasOne("fjorubordid_database.Models.OrderItem", null)
                        .WithMany("Drink")
                        .HasForeignKey("OrderItemId");
                });

            modelBuilder.Entity("fjorubordid_database.Models.Food", b =>
                {
                    b.HasOne("fjorubordid_database.Models.OrderItem", "OrderItem")
                        .WithMany("Food")
                        .HasForeignKey("OrderItemId");

                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("fjorubordid_database.Models.OrderItem", b =>
                {
                    b.Navigation("Drink");

                    b.Navigation("Food");
                });
#pragma warning restore 612, 618
        }
    }
}
