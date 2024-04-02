using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public required IdentityUser User { get; set; }

        public int ProductId { get; set; }
        public required ICollection<Product> Products { get; set; } = new List<Product>();

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
    }
}

