
using StellarGoodsData.Enum;
using StellarGoodsData.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{

    public class Order : BaseModel<Order>, IDeletableEntity
    {
        public int UserId { get; set; }
        public required User User { get; set; }

        public DateTime? OrderDate { get; set; }

        public Status Status { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        public required Address ShippingAddress { get; set; }

        public required Address BillingAddress { get; set; }

        public int OrderItemId { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
