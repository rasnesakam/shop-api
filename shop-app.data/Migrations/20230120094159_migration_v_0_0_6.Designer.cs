﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using shop_app.data.Concrete.EfCore;

#nullable disable

namespace shop_app.data.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20230120094159_migration_v_0_0_6")]
    partial class migration_v_0_0_6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("shop_app.entity.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("character varying(140)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(140)
                        .HasColumnType("character varying(140)");

                    b.Property<string>("AddressType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("SaveAddress")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("shop_app.entity.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("URI")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2226de31-63bc-40d4-89cd-0baa5e7fd099"),
                            Name = "Telefon",
                            URI = "telefon"
                        },
                        new
                        {
                            Id = new Guid("d5fb8c9c-ec25-4ff5-b717-20d846e63c93"),
                            Name = "Bilgisayar",
                            URI = "bilgisayar"
                        },
                        new
                        {
                            Id = new Guid("87bc9408-e860-474c-ae51-026320645825"),
                            Name = "TV",
                            URI = "tv"
                        },
                        new
                        {
                            Id = new Guid("492f9f83-2a90-426b-82bd-b75a587a0351"),
                            Name = "Beyaz Eşya",
                            URI = "beyaz-esya"
                        },
                        new
                        {
                            Id = new Guid("a7573984-701e-498e-8dda-181dd0d5ea06"),
                            Name = "Hobi",
                            URI = "hobi"
                        });
                });

            modelBuilder.Entity("shop_app.entity.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("Temporary")
                        .HasColumnType("boolean");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("shop_app.entity.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<string>("CustomerNote")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("uuid");

                    b.Property<string>("SellerNote")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("shop_app.entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric(12,2)");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.HasIndex("Uri")
                        .IsUnique();

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e45eb73-3656-49f5-b693-bce9064a97c9"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Iphone 13, temiz kullanılmış yalnızca ciddi alıcılar",
                            Name = "Sahibinden temiz İphone",
                            Price = 10000.00m,
                            SellerId = new Guid("3988518e-2f7f-45e9-8f40-cd9b6693ea52"),
                            Uri = "bef371bd-b267-4a3e-983e-c1aa467ba300"
                        },
                        new
                        {
                            Id = new Guid("692469d0-19d9-4fbb-8cb5-72ca30c016d1"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ciddi alıcılar",
                            Name = "Temiz kullanılmış Macbook M1 Air",
                            Price = 20000.00m,
                            SellerId = new Guid("3988518e-2f7f-45e9-8f40-cd9b6693ea52"),
                            Uri = "cfdb0719-57ff-4c7c-8fed-1e65747dc4b2"
                        },
                        new
                        {
                            Id = new Guid("a1bfa642-119c-4b22-a510-43b694c7eefa"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Duvara as, tablo diye izle",
                            Name = "LG nin incecik televizyonu",
                            Price = 100.00m,
                            SellerId = new Guid("3988518e-2f7f-45e9-8f40-cd9b6693ea52"),
                            Uri = "ec4173d3-97a5-46f2-a012-5684101a7cc9"
                        },
                        new
                        {
                            Id = new Guid("781e93ba-34d9-4cb4-a367-eb363a56fbba"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Güzel soğutur, benim cesedi 10 gün sakladı",
                            Name = "Buz Dolabı",
                            Price = 100.00m,
                            SellerId = new Guid("3988518e-2f7f-45e9-8f40-cd9b6693ea52"),
                            Uri = "574a0e28-9447-4e3c-b8e7-b0f43af32e61"
                        },
                        new
                        {
                            Id = new Guid("183a1e3d-7c2d-47c1-bd74-aa2b4296db40"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hobi amaçlı matkap",
                            Name = "Matkap",
                            Price = 100.00m,
                            SellerId = new Guid("3988518e-2f7f-45e9-8f40-cd9b6693ea52"),
                            Uri = "46d2ef77-4003-4d56-ad7d-31da8be18e0b"
                        });
                });

            modelBuilder.Entity("shop_app.entity.ProductCategory", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("2226de31-63bc-40d4-89cd-0baa5e7fd099"),
                            ProductId = new Guid("0e45eb73-3656-49f5-b693-bce9064a97c9"),
                            Id = new Guid("0e0ddb64-fb0d-4c6c-bd47-8f571e4dbed9")
                        },
                        new
                        {
                            CategoryId = new Guid("d5fb8c9c-ec25-4ff5-b717-20d846e63c93"),
                            ProductId = new Guid("692469d0-19d9-4fbb-8cb5-72ca30c016d1"),
                            Id = new Guid("3a5eb4b2-7108-40ec-a3c7-604909c68727")
                        },
                        new
                        {
                            CategoryId = new Guid("87bc9408-e860-474c-ae51-026320645825"),
                            ProductId = new Guid("a1bfa642-119c-4b22-a510-43b694c7eefa"),
                            Id = new Guid("9adb7028-f3b3-4fec-86d0-1d9766befe58")
                        },
                        new
                        {
                            CategoryId = new Guid("492f9f83-2a90-426b-82bd-b75a587a0351"),
                            ProductId = new Guid("781e93ba-34d9-4cb4-a367-eb363a56fbba"),
                            Id = new Guid("e4c65299-978f-4273-91c4-d7b6f49a03b8")
                        },
                        new
                        {
                            CategoryId = new Guid("a7573984-701e-498e-8dda-181dd0d5ea06"),
                            ProductId = new Guid("183a1e3d-7c2d-47c1-bd74-aa2b4296db40"),
                            Id = new Guid("bf2310d4-27ec-48d8-ac4a-8bda5c5e4402")
                        });
                });

            modelBuilder.Entity("shop_app.entity.ProductImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AltText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileUri")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d16690df-0e77-4a1a-9b54-046d366ff296"),
                            AltText = "iphone",
                            FileUri = "front.png",
                            ProductId = new Guid("0e45eb73-3656-49f5-b693-bce9064a97c9")
                        },
                        new
                        {
                            Id = new Guid("0de3df23-6474-4bb7-bda4-6eb8d07a10a9"),
                            AltText = "macbook m1",
                            FileUri = "front.png",
                            ProductId = new Guid("692469d0-19d9-4fbb-8cb5-72ca30c016d1")
                        },
                        new
                        {
                            Id = new Guid("caa49102-b554-4bb7-9061-d86a9deb0ae5"),
                            AltText = "televizyon",
                            FileUri = "front.png",
                            ProductId = new Guid("a1bfa642-119c-4b22-a510-43b694c7eefa")
                        },
                        new
                        {
                            Id = new Guid("005012e8-cb77-4e9c-9218-bbdb23cda966"),
                            AltText = "buz dolabı",
                            FileUri = "front.png",
                            ProductId = new Guid("781e93ba-34d9-4cb4-a367-eb363a56fbba")
                        },
                        new
                        {
                            Id = new Guid("38821c7e-565b-4e05-a919-4622a41861a4"),
                            AltText = "matkap",
                            FileUri = "front.png",
                            ProductId = new Guid("183a1e3d-7c2d-47c1-bd74-aa2b4296db40")
                        });
                });

            modelBuilder.Entity("shop_app.entity.ProductOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOrder");
                });

            modelBuilder.Entity("shop_app.entity.Property", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("shop_app.entity.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("shop_app.entity.Seller", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3988518e-2f7f-45e9-8f40-cd9b6693ea52"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f6c2ec2d-b1b7-4327-ba39-bb0df2bc8449",
                            Email = "bataryadunyasi@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Batarya Dünyası",
                            NormalizedUserName = "BATARYADUNYASI",
                            PasswordHash = "13f8aa151a8bfcb071dd915abce080a19ef198b8298552eedc5ccc5a9d0a3e3e",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "bataryadunyasi"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("shop_app.entity.Seller", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("shop_app.entity.Seller", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shop_app.entity.Seller", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("shop_app.entity.Seller", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("shop_app.entity.Order", b =>
                {
                    b.HasOne("shop_app.entity.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shop_app.entity.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shop_app.entity.Seller", "Seller")
                        .WithMany("Orders")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Customer");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("shop_app.entity.Product", b =>
                {
                    b.HasOne("shop_app.entity.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("shop_app.entity.ProductCategory", b =>
                {
                    b.HasOne("shop_app.entity.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shop_app.entity.Product", "Product")
                        .WithMany("Products")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("shop_app.entity.ProductImage", b =>
                {
                    b.HasOne("shop_app.entity.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("shop_app.entity.ProductOrder", b =>
                {
                    b.HasOne("shop_app.entity.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shop_app.entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("shop_app.entity.Property", b =>
                {
                    b.HasOne("shop_app.entity.Product", null)
                        .WithMany("Properties")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("shop_app.entity.Review", b =>
                {
                    b.HasOne("shop_app.entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shop_app.entity.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("shop_app.entity.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("shop_app.entity.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("shop_app.entity.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("shop_app.entity.Product", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("ProductImages");

                    b.Navigation("Properties");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("shop_app.entity.Seller", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
