using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Product: EntityBase
    {
        public Product() { }
        public Product(string title, string description, decimal price, decimal discount)
        {
            Title = title;
            Description = description;
            Price = price;
            Discount = discount;
        }

        public required string Title { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required decimal Discount { get; set; }
        public required int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
