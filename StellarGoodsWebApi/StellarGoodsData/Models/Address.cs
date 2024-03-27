namespace StellarGoodsData.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}