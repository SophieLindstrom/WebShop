using System;
using System.Collections.Generic;

#nullable disable

namespace WebShop.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public bool? Gender { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
