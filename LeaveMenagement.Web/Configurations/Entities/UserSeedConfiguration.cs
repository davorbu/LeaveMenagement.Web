using LeaveMenagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveMenagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    NormalizedUserName = "ADMIN@TEST.COM",
                    Firstname = "AdminTest",
                    Lastname = "Test",
                    PasswordHash = hasher.HashPassword(null, "Password1"),
                    EmailConfirmed = true

                },

                new Employee
                {
                    Id = "1669760b-612f-4f60-b4b0-427a53ab1dc9",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "Password1"),
                    EmailConfirmed = true

                }


            ) ;
        }
    }
}