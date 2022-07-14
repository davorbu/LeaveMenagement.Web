using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveMenagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    //1669760b-612f-4f60-b4b0-427a53ab1dc9
                    Id = "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                   
                    Id = "1889760b-912f-6f60-b4b0-649a53ab1dc9",
                    Name = "User",
                    NormalizedName = "USER"
                }

            );
        }
    }
}