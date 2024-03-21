using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace StellarGoodsData.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
