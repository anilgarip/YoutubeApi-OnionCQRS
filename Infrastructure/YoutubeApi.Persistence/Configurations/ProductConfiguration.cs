using Bogus;
using Microsoft.EntityFrameworkCore;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new ("tr");

            Product product1 = new()
            {
                Id = 30,
                IsDeleted = false,
                BrandId = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Discount = faker.Random.Decimal(0,10),
                Price = faker.Finance.Amount(10,1000),
                CreatedDate = DateTime.Now
            };

            Product product2 = new()
            {
                Id = 40,
                IsDeleted = false,
                BrandId = 3,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 1000),
                CreatedDate = DateTime.Now
            };

            builder.HasData(product1, product2);
        }
    }
}
