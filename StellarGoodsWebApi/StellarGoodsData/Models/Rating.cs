using System.ComponentModel.DataAnnotations;

namespace StellarGoodsData.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Product Product { get; set; }

        [Range(0, 5)]
        public double Rate { get; set; }

    }
}
