using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeLeave.Data
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "c42c2f4f-11d4-435e-a468-05919ff33347",
                    UserId = "2313c553-9fc2-4d67-aade-3e8eb6a50ab0"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "c42c3f5f-11d4-435e-a468-05919ff33347",
                    UserId = "c42c2f4f-11d4-435e-a468-05919f513347"
                }
           );
        }
    }
}