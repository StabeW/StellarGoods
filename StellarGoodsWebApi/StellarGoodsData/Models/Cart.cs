using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName ="money")]
        public decimal TotalPrice { get; set; }
    }
}
