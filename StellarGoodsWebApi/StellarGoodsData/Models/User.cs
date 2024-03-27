using Microsoft.AspNetCore.Identity;
using StellarGoodsData.Common.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class User : IdentityUser, IAuditInfo, IDeletableEntity
    {

        [Column(TypeName = "nvarchar(50)")]
        public required string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public required string LastName { get; set; }

        public int CartId { get; set; }
        public required Cart Cart { get; set; }

        public int AddressId { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        public int OrderId { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public int RatingId { get; set; }
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();

        public DateTime CreatedOn { get; } = DateTime.Now;

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
