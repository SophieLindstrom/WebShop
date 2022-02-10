using System;
using System.Collections.Generic;

#nullable disable

namespace WebShop.Models
{
    public partial class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string ShipperName { get; set; }
        public decimal? FreightPrice { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
