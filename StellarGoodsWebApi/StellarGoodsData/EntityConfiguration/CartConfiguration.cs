using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StellarGoodsData.Models;

namespace StellarGoodsData.EntityConfiguration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .HasMany(p => p.Products)
                .WithOne(c => c.Cart)
                .HasForeignKey(c => c.CartId);

            builder
                .HasOne(u => u.User)
                .WithOne(c => c.Cart);
        }
    }
}
