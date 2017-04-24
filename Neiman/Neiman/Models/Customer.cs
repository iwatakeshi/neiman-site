using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neiman.Models
{
    public class Customer
    {
        // A customer must have an ID
        public int ID { get; set; }
        // A customer must have a first name
        public string FirstName { get; set; }
        // A customer must have a last name
        public string LastName { get; set; }
        // A customer must have a primary address line
        public string AddressLine1 { get; set; }
        // A customer may have a secondary address line
        public string AddressLine2 { get; set; }
        // A customer must live in a city
        public string City { get; set; }
        // A customer must live in a State
        public string State { get; set; }
        // A customer must have a zip code
        public string Zipcode { get; set; }
        // A customer must have a phone number
        public string Phone { get; set; }
        // A customer must have an email address
        public string Email { get; set; }
        // A customer may be a company
        public string Company { get; set; }
        // A customer may have a purchase order
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
