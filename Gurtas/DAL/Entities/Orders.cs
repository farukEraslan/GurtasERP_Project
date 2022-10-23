using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurtas.DAL.Entities
{
    public class Orders : BaseEntity
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string Supplier { get; set; }
        public string ContactName { get; set; }
        public string? BidNumber { get; set; }
        public string OrderDetail { get; set; }
        public string Quantity { get; set; }
        public string? Material { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string? DeliveryTime { get; set; }
        public int? Discount { get; set; }
        public string? PackagingDetail { get; set; }
        public string? ShippingDetail { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentTerm { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }


        public int UserId { get; set; }
        public virtual Users User { get; set; }


    }
}
