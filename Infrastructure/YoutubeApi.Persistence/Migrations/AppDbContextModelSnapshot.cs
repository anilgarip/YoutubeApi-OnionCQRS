﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoutubeApi.Persistence.Context;

#nullable disable

namespace YoutubeApi.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("YoutubeApi.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 568, DateTimeKind.Local).AddTicks(686),
                            IsDeleted = false,
                            Name = "Automotive, Baby & Games"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 568, DateTimeKind.Local).AddTicks(692),
                            IsDeleted = false,
                            Name = "Industrial"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 568, DateTimeKind.Local).AddTicks(697),
                            IsDeleted = true,
                            Name = "Movies"
                        });
                });

            modelBuilder.Entity("YoutubeApi.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 569, DateTimeKind.Local).AddTicks(8960),
                            IsDeleted = false,
                            Name = "Elektronik",
                            ParentId = 0,
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 569, DateTimeKind.Local).AddTicks(8962),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priority = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 569, DateTimeKind.Local).AddTicks(8963),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priority = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 569, DateTimeKind.Local).AddTicks(8965),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priority = 1
                        });
                });

            modelBuilder.Entity("YoutubeApi.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 571, DateTimeKind.Local).AddTicks(5326),
                            Description = "Totam sit quis ratione quaerat.",
                            IsDeleted = false,
                            Title = "Masanın."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 571, DateTimeKind.Local).AddTicks(5448),
                            Description = "Praesentium voluptas architecto lambadaki öyle.",
                            IsDeleted = true,
                            Title = "Karşıdakine çünkü."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 4, 4, 16, 45, 51, 571, DateTimeKind.Local).AddTicks(5482),
                            Description = "Umut iusto yaptı consectetur autem.",
                            IsDeleted = false,
                            Title = "Ekşili ullam."
                        });
                });

            modelBuilder.Entity("YoutubeApi.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("YoutubeApi.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YoutubeApi.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeApi.Domain.Entities.Detail", b =>
                {
                    b.HasOne("YoutubeApi.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("YoutubeApi.Domain.Entities.Product", b =>
                {
                    b.HasOne("YoutubeApi.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("YoutubeApi.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
