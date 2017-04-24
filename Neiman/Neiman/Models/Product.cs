using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neiman.Models
{
    public class Product
    {
        // A product must have an ID
        public int ID { get; set; }
        // A product must have a name
        public string Name { get; set; }
        // A product must have a price
        public decimal Price { get; set; }
        // A product must have a description
        public string Description { get; set; }
        // a product must have a category
        public virtual Category Category { get; set; }

    }
}
