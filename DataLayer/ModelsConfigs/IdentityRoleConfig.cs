using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.ModelsConfigs
{
    internal class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
                (
                new IdentityRole() { Name = "Admin",ConcurrencyStamp = "1",NormalizedName = "Admin" },
                new IdentityRole() { Name = "Buyer", ConcurrencyStamp = "2", NormalizedName = "Buyer" },
                new IdentityRole() { Name = "Seller", ConcurrencyStamp = "3", NormalizedName = "Seller" },
                new IdentityRole() { Name = "Both", ConcurrencyStamp = "4", NormalizedName = "Both" }
                );

        }
    }
}
