using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveMenagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string> 
                {
                    RoleId = "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                    UserId = "1779760b-612f-5f60-b4b0-538a53ab1dc9"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "1889760b-912f-6f60-b4b0-649a53ab1dc9",
                    UserId = "1669760b-612f-4f60-b4b0-427a53ab1dc9"
                }

            );
        }
    }
}