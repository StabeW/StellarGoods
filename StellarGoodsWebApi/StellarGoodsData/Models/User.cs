using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StellarGoodsData.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Username { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Column(TypeName ="varchar(80)")]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[\w-]{2,4}$")]
        public string Email { get; set; }

        [RegularExpression("@\"^\\d{3}-\\d{3}-\\d{4}$\"")]
        public string PhoneNumber { get; set; }

        public DateTime RegisterOn { get; set; } = DateTime.Now;

        public int AddressId { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
