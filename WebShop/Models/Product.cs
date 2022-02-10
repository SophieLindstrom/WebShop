using System;
using System.Collections.Generic;

#nullable disable

namespace WebShop.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? ProductCategoryId { get; set; }
        public decimal? ProductPrice { get; set; }
        public string ProductInfo { get; set; }

        public virtual Category ProductCategory { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
