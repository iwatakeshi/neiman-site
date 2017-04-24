using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neiman.Models
{
    public class Category
    {
        // A category must have an ID
        public int ID { get; set; }
        // A category must have a Name
        public string Name { get; set; }
        // A category may have zero or more products assigned with it
        public virtual ICollection<Product> Products { get; set; }
    }
}
