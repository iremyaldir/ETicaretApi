using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

         

            Brand brand1 = new()
            { 
                Id=1,
                Name = "Test1",
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            Brand brand2 = new()
            {
                Id = 2,
                Name = "Test2",
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            Brand brand3 = new()
            {
                Id = 3,
                Name = "Test3",
                CreatedTime = DateTime.Now,
                IsDeleted = true,
            };

            builder.HasData(brand1, brand2, brand3);
        }
    }
}
