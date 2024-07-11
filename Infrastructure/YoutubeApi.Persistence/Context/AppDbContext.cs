using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Entities;
using YoutubeApi.Persistence.Configurations;

namespace YoutubeApi.Persistence.Context
{

    // ApplicationDbContextSeed.cs
    public static class ApplicationDbContextSeed
    {
        /*public static void SeedInitialData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Ürün 1",
                    Description = "Ürün 1 Açıklaması",
                    BrandId = 1,
                    Price = 100,
                    Discount = 10,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Product
                {
                    Id = 2,
                    Title = "Ürün 2",
                    Description = "Ürün 2 Açıklaması",
                    BrandId = 2,
                    Price = 200,
                    Discount = 15,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
            // Diğer ürünler buraya eklenebilir
            );

            // Diğer tablolar için de aynı şekilde seed işlemi yapılabilir
        }*/
    }

    public class AppDbContext : DbContext
    {

        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Brand> Brands { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // modelBuilder.SeedInitialData();
            modelBuilder.Entity<Product>()
         .Property(p => p.Discount)
         .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}

