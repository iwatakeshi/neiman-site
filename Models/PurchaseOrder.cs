using System.Collections.Generic;

namespace neiman_site.Models
{
    public class PurchaseOrder
    {
        // A purchase order must have an ID
        public int ID { get; set; }
        // A purchase order must have a single customer
        public virtual Customer Customer { get; set; }
        // A purchase order must have one or more products
        public virtual ICollection<Product> Products { get; set; }
    }
}