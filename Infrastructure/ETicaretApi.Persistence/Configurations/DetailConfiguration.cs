using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Detail detail1 = new()
            {
                Id = 1,
                Title = "Telephone Detail",
                Description = "Iphone",
                CategoryId = 1,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            
            Detail detail2 = new()
            {
                Id = 2,
                Title = "Macbook Detail",
                Description = "M3-MacbookPro",
                CategoryId = 3,
                CreatedTime = DateTime.Now,
                IsDeleted = true,
            };
            Detail detail3 = new()
            {
                Id = 3,
                Title = "Skirt Detail",
                Description = "Black-Leather-Skirt",
                CategoryId = 4,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };
            builder.HasData(detail1, detail2, detail3); 
            
        }
    }
}
