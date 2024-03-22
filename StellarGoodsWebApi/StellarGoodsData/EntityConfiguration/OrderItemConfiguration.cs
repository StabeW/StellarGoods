using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StellarGoodsData.Models;

namespace StellarGoodsData.EntityConfiguration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        void IEntityTypeConfiguration<OrderItem>.Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(o => new { o.OrderId, o.ProductId });

            builder
                .HasOne(o => o.Order)
                .WithMany(i => i.OrderItems)
                .HasForeignKey(o => o.OrderId);

            builder
                .HasOne(p => p.Product)
                .WithMany(i => i.OrderItems)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
