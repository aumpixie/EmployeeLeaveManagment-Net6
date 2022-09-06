using EmployeeLeaveManagment.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeLeaveManagment.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "159b13b5-b641-4036-b7b2-f7719ff446df",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                 new IdentityRole
                 {
                     Id = "159b10b5-b641-4036-b6b0-f7719ff456df",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper()
                 }
                );
            
        }
    }
}