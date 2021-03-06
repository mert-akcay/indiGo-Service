// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using indiGo.Data.EntityFramework;

#nullable disable

namespace indiGo.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("Receipted")
                        .HasColumnType("bit");

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
                            ConcurrencyStamp = "82e1f11e-9703-4801-9f97-557d4b7667aa",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEHp4EV2Gywu9QkbnhZtAxBhapAlk+abLWUVZvFtDEVTDScyw3V/uI4r6Ze5SS1x6Eg==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 9, 17, 85, DateTimeKind.Utc).AddTicks(4980),
                            SecurityStamp = "81052e58-97b2-487d-be2a-eae8cb15d896",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "650ab114-4c82-4792-8121-67af15de182f",
                            Email = "operator@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Operator",
                            LastName = "Operator",
                            LockoutEnabled = false,
                            NormalizedUserName = "OPERATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEOMmIhkUUAvAO4c0g2WIbu/DDAviBX4MIDRJUKYKls7z5GkLhlvjp6f2L/K66h2CtQ==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 9, 17, 90, DateTimeKind.Utc).AddTicks(9313),
                            SecurityStamp = "980d9dd3-edfa-40a4-950c-368173c988b0",
                            TwoFactorEnabled = false,
                            UserName = "operator"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "96aabd04-d52c-4050-8a01-02e03a46c803",
                            Email = "mandosi@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Mandosi",
                            LastName = "Paki",
                            LockoutEnabled = false,
                            NormalizedUserName = "MANDOSI",
                            PasswordHash = "AQAAAAEAACcQAAAAEF49EHl28tVZGjNOtZsmjE2SmuO174vpCkON4oLGY1dvon2M3bfhVl4xiqLVTMdEcA==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 9, 17, 96, DateTimeKind.Utc).AddTicks(2358),
                            SecurityStamp = "af874e63-7c6c-43bf-a214-9c60835014f0",
                            TwoFactorEnabled = false,
                            UserName = "mandosi"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a6c6-8223d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a5e14e6e-e02b-4424-aceb-2bc1fd4004ea",
                            Email = "bewar@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Bewar",
                            LastName = "Dılbixhin",
                            LockoutEnabled = false,
                            NormalizedUserName = "BEWAR",
                            PasswordHash = "AQAAAAEAACcQAAAAEIS59McxPQ4pY9kjQ4oXEGz+j2vJwczHEmQUh3ulnCfzJHoLZvngUiJDOEnn98Vxrg==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 9, 17, 101, DateTimeKind.Utc).AddTicks(5642),
                            SecurityStamp = "8b1e893b-a096-47d8-ad96-a83a15e90079",
                            TwoFactorEnabled = false,
                            UserName = "bewar"
                        },
                        new
                        {
                            Id = "8e443125-a24d-4543-a5g5-8223d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "832fe743-eb0b-42c6-80f1-254779bb64ab",
                            Email = "cumali@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Cumali",
                            LastName = "Cemalikızık",
                            LockoutEnabled = false,
                            NormalizedUserName = "CUMALI",
                            PasswordHash = "AQAAAAEAACcQAAAAEEqdrvlREiatb5PG6Vg4yePauZfDwNEmkNO4ezlEdX6SXcl9TI+jfTQO0F44kI3bqg==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(2022, 6, 10, 11, 9, 17, 107, DateTimeKind.Utc).AddTicks(4567),
                            SecurityStamp = "f4689c0b-aa86-4c4d-87df-e4eb20f9ef64",
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
                            ConcurrencyStamp = "2369cdb7-bda4-4a86-b776-78ac6f9802b4",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "53ea4479-6c36-4bb0-ab74-4c374da23a5b",
                            Name = "CUSTOMER",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "272a798b-17c8-481e-890d-30a4eddaa3a2",
                            Name = "OPERATOR",
                            NormalizedName = "OPERATOR"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "bb4a586f-998b-473e-bee1-7706d8d90f5a",
                            Name = "PASSIVE",
                            NormalizedName = "PASSIVE"
                        },
                        new
                        {
                            Id = "5",
                            ConcurrencyStamp = "01f9a583-12e0-4890-aa04-4c323d0b91f6",
                            Name = "ELECTRICALSERVICE",
                            NormalizedName = "ELECTRICALSERVICE"
                        },
                        new
                        {
                            Id = "6",
                            ConcurrencyStamp = "5a4eb3a0-f050-4e53-95ed-fabbe4ee0074",
                            Name = "GASSERVICE",
                            NormalizedName = "GASSERVICE"
                        },
                        new
                        {
                            Id = "7",
                            ConcurrencyStamp = "cb8949b7-7a0c-4aef-b633-75bef6f1580d",
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
