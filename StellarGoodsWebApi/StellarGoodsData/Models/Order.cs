using StellarGoodsData.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class Order
    {
        public int Id { get; set; }

        public User User { get; set; }

        public DateTime? OrderDate { get; set; }

        public Status Status { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        public string ShippingAddress { get; set; }

        public string BillingAddress { get; set; }
    }
}
