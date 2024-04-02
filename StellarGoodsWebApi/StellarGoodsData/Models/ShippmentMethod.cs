using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class ShippingMethod
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        public DateTime DeliveryTime { get; set; }
    }
}
