// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using indiGo.Data.EntityFramework;

#nullable disable

namespace indiGo.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220610110346_ReceiptEntryFix")]
    partial class ReceiptEntryFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("indiGo.Core.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApartmentNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlatNo")
                        .HasColumnType("int");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("indiGo.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal>("Price")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("indiGo.Core.Entities.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DemandId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DemandId");

                    b.HasIndex("Id");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("indiGo.Core.Entities.ReceiptDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId1")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ReceiptId")
                        .HasColumnType("int");

                    b.Property<int?>("ReceiptId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductId1");

                    b.HasIndex("ReceiptId");

                    b.HasIndex("ReceiptId1");

                    b.ToTable("ReceiptDetail");
                });

            modelBuilder.Entity("indiGo.Core.Entities.ServiceDemand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ServiceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKN")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .IsFixedLength();

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceDemands");
                });

            modelBuilder.Entity("indiGo.Data.Identity.ApplicationUser", b =>
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
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = "8e552862-a24d-4548-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0c875de8-4513-4e86-84ca-5e785b4b02f6",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEHdc+WVibH+vMvqDG/G62EQ2tHtxZWdd4bP8G75BWEAmM/JfQ2Q7VusWNTa+bKTZ0w==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 3, 46, 470, DateTimeKind.Utc).AddTicks(2111),
                            SecurityStamp = "1a186c81-1e91-41e4-a28c-2a9f3a7f0382",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fda00ab4-045b-4472-8e8f-bb5c324f73ae",
                            Email = "operator@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Operator",
                            LastName = "Operator",
                            LockoutEnabled = false,
                            NormalizedUserName = "OPERATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEHJh3/ASld8Zc2S3IpUWI8B42gkNq6lSJpjpQVU+6T6Nz9hh/HbXw15JZzKjZlfXiQ==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 3, 46, 475, DateTimeKind.Utc).AddTicks(5445),
                            SecurityStamp = "324d17af-4491-4b48-a39e-7ed7038339e0",
                            TwoFactorEnabled = false,
                            UserName = "operator"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3ab8800c-9ae8-4bde-83ff-fc2ad5fd9f88",
                            Email = "mandosi@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Mandosi",
                            LastName = "Paki",
                            LockoutEnabled = false,
                            NormalizedUserName = "MANDOSI",
                            PasswordHash = "AQAAAAEAACcQAAAAEKsVaZBNFvPAIpKIqOlpuraesdrZlF20X3jf3ZJxgGqtGuR3NGZuihWKUDnnfnDaOg==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 3, 46, 481, DateTimeKind.Utc).AddTicks(4988),
                            SecurityStamp = "81a3c0db-dfde-476e-8719-3655972f2427",
                            TwoFactorEnabled = false,
                            UserName = "mandosi"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a6c6-8223d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dc8e2e45-cd4b-4b7d-ba3d-cc51aac997d9",
                            Email = "bewar@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Bewar",
                            LastName = "Dılbixhin",
                            LockoutEnabled = false,
                            NormalizedUserName = "BEWAR",
                            PasswordHash = "AQAAAAEAACcQAAAAEFyj1MOcsD5LBUXFYhObElio6iirJ31XZ0nsqFwZOljgm1oY1wfHEcUN2Ye9V0lR6A==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 3, 46, 486, DateTimeKind.Utc).AddTicks(8065),
                            SecurityStamp = "2ea948fe-d8e6-46f3-8923-240f75cd84aa",
                            TwoFactorEnabled = false,
                            UserName = "bewar"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a5g5-8223d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7dfcbc6f-3539-4981-92ef-ec20317b546b",
                            Email = "cumali@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Cumali",
                            LastName = "Cemalikızık",
                            LockoutEnabled = false,
                            NormalizedUserName = "CUMALI",
                            PasswordHash = "AQAAAAEAACcQAAAAEA+QWUoDlVlEkeZ2tH4SuAk0wUkhIfLz7wv8v5LX93kmV7tXk0bQW36Ghpcgep5w/g==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 3, 46, 492, DateTimeKind.Utc).AddTicks(1495),
                            SecurityStamp = "fd63708e-19ff-47a6-afe5-9860e430970f",
                            TwoFactorEnabled = false,
                            UserName = "cumali"
                        });
                });

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
                            Id = "1",
                            ConcurrencyStamp = "4b16b586-67db-47b4-81ce-c7d43631ebc9",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "449fd16e-6b42-41bd-9b46-fde6fa460b4a",
                            Name = "CUSTOMER",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "60dc7f10-39d4-40e5-98fb-011fc23ecbbb",
                            Name = "OPERATOR",
                            NormalizedName = "OPERATOR"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "63f06136-39f9-4136-8eca-73801de5922a",
                            Name = "PASSIVE",
                            NormalizedName = "PASSIVE"
                        },
                        new
                        {
                            Id = "5",
                            ConcurrencyStamp = "ce316cff-163b-41e5-90f8-bc8cc9bc38a5",
                            Name = "ELECTRICALSERVICE",
                            NormalizedName = "ELECTRICALSERVICE"
                        },
                        new
                        {
                            Id = "6",
                            ConcurrencyStamp = "703648b4-54ba-4d39-8307-cbba6d2045be",
                            Name = "GASSERVICE",
                            NormalizedName = "GASSERVICE"
                        },
                        new
                        {
                            Id = "7",
                            ConcurrencyStamp = "1f69d0f9-5709-44c9-8794-8ae5e0485cbc",
                            Name = "PLUMBINGSERVICE",
                            NormalizedName = "PLUMBINGSERVICE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.HasData(
                        new
                        {
                            UserId = "8e552862-a24d-4548-a6c6-9443d048cdb9",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "8e443125-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "5"
                        },
                        new
                        {
                            UserId = "8e443125-a24d-4543-a6c6-8223d048cdb9",
                            RoleId = "6"
                        },
                        new
                        {
                            UserId = "8e443125-a24d-4543-a5g5-8223d048cdb9",
                            RoleId = "7"
                        });
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

            modelBuilder.Entity("indiGo.Core.Entities.Address", b =>
                {
                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("indiGo.Core.Entities.Receipt", b =>
                {
                    b.HasOne("indiGo.Core.Entities.ServiceDemand", "Demand")
                        .WithMany()
                        .HasForeignKey("DemandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Demand");
                });

            modelBuilder.Entity("indiGo.Core.Entities.ReceiptDetail", b =>
                {
                    b.HasOne("indiGo.Core.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("indiGo.Core.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");

                    b.HasOne("indiGo.Core.Entities.Receipt", null)
                        .WithMany()
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("indiGo.Core.Entities.Receipt", "Receipt")
                        .WithMany()
                        .HasForeignKey("ReceiptId1");

                    b.Navigation("Product");

                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("indiGo.Core.Entities.ServiceDemand", b =>
                {
                    b.HasOne("indiGo.Core.Entities.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
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
                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
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

                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("indiGo.Data.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
