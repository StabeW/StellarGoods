using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StellarGoodsData.Models;

namespace StellarGoodsData
{
    public class StellarGoodsContext : IdentityDbContext<User, IdentityRole, string>
    {
        public StellarGoodsContext(DbContextOptions<StellarGoodsContext> options) 
            : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<ShippingMethod> ShippingMethods { get; set; }
    }
}


