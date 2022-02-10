using System;
using System.Collections.Generic;

#nullable disable

namespace WebShop.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int? OrderCustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? OrderShipperId { get; set; }
        public int? OrderPaymentId { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Customer OrderCustomer { get; set; }
        public virtual Payment OrderPayment { get; set; }
        public virtual Shipper OrderShipper { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
