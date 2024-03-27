
using StellarGoodsData.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetCoreTemplate.Data.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace StellarGoodsData.Models
{

    public class Order : BaseDeletableModel<Order>
    {
        public int UserId { get; set; }
        public required IdentityUser User { get; set; }

        public DateTime? OrderDate { get; set; }

        public Status Status { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        public required Address ShippingAddress { get; set; }

        public required Address BillingAddress { get; set; }

        public int OrderItemId { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
