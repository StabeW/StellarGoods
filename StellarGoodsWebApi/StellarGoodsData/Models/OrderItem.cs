using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public required Order Order { get; set; }

        public int ProductId { get; set; }
        public required Product Product { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}


