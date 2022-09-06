using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeLeaveManagment.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "159b13b5-b641-4036-b7b2-f7719ff446df",
                    UserId= "159e13b5-b341-4034-b7b2-f7779ff445df"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "159b10b5-b641-4036-b6b0-f7719ff456df",
                    UserId = "155e11b5-b341-4011-b7b2-f7279ff445df"
                });
        }
    }
}