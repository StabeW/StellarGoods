using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool Available { get; set; }

        [Column(TypeName ="varbinary")]
        public string Image { get; set; }
    }
}
