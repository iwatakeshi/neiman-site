using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Range(0.01, 10000, ErrorMessage = "Please enter a price between 0.01 and 10000.00")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        // A product must have a quantity
        [Range(0, 10000, ErrorMessage = "Please enter a quantity between 0 and 10000")]
        public int Quantity { get; set; }
        // A product must have a description
        public string Description { get; set; }
        // a product must have a category
        public virtual Category Category { get; set; }

    }
}
