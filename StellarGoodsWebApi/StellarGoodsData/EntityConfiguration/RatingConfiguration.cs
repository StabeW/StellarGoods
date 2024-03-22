using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StellarGoodsData.Models;

namespace StellarGoodsData.EntityConfiguration
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(r => r.Id);

            builder
                .HasOne(u => u.User)
                .WithMany(r => r.Ratings)
                .HasForeignKey(r => r.UserId);

            builder
                .HasOne(p => p.Product)
                .WithMany(r => r.Ratings)
                .HasForeignKey(r => r.ProductId);
        }
    }
}
