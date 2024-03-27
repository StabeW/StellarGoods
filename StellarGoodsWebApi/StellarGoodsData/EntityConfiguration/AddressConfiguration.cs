using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StellarGoodsData.Models;

namespace StellarGoodsData.EntityConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(u => u.User)
                .WithMany(a => a.Addresses)
                .HasForeignKey(k => k.UserId);
        }
    }
}