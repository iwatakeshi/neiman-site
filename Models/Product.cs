using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neiman_site.Models
{
    public class Product
    {
        // A product must have an ID
        public int ID { get; set; }
        // A product must have a Name
        public string Name { get; set; }
        // A product must have a Price
        public decimal Price { get; set; }
        // A product must have a Description
        public string Description { get; set; }
        // A product must have a Quantity
        public int Quantity { get; set; }

    }
}
