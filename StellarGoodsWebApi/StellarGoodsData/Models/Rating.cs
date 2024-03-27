using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace StellarGoodsData.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public required IdentityUser User { get; set; }

        public int ProductId { get; set; }
        public required Product Product { get; set; }

        [Range(0, 5)]
        public double Rate { get; set; }
    }
}

