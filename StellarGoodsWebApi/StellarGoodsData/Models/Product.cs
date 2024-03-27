using AspNetCoreTemplate.Data.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class Product : BaseDeletableModel<Product>
    {
        public required string Name { get; set; }

        public required string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool Available { get; set; }
  
        public int CartId { get; set; }
        public required Cart Cart { get; set; }

        public int RatingId { get; set; }
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();

        public int OrderItemId { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}

