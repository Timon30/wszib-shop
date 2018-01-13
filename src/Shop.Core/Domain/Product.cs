using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Domain
{
    public class Product
    {
        public Guid id { get; } 
        public string Name { get; }
        public string Category { get; set; }
        public decimal Price { get; }
        public Guid Id { get; set; }

        public Product(string name, string category, decimal price)
        {
            id = Guid.NewGuid();
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
