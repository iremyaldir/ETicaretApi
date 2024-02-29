using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Product product1 = new()
            {
                Id = 1,
                Title = "Telephone Product",
                Description = "Telephone Description",
                BrandId = 1,
                Discount = 10,
                Price = 10000,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            Product product2 = new()
            {
                Id = 2,
                Title = "Skirt Product",
                Description = "Skirt Description",
                BrandId = 2,
                Discount = 10,
                Price = 5000,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            builder.HasData(product1, product2);
        }
    }
}
