using Microsoft.AspNetCore.Identity;
using StellarGoodsData.Common.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class User : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public int Id { get; set; }
     
        public required string Username { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$")]
        public required string Password { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public required string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public required string LastName { get; set; }

        [Column(TypeName = "varchar(80)")]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[\w-]{2,4}$")]
        public required string Email { get; set; }

        [RegularExpression("@\"^\\d{3}-\\d{3}-\\d{4}$\"")]
        public required string PhoneNumber { get; set; }

        public int CartId { get; set; }
        public required Cart Cart { get; set; }

        public int AddressId { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        public int OrderId { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public int RatingId { get; set; }
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime? ModifiedOn { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; } = DateTime.Now;
    }
}
