using EmployeeLeaveManagment.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeLeaveManagment.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee { 
                    Id = "159e13b5-b341-4034-b7b2-f7779ff445df",
                    Email = "admin@test.com",
                    NormalizedEmail ="ADMIN@TEST.COM",
                    NormalizedUserName = "ADMIN@TEST.COM",
                    UserName = "admin@test.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null,"P@ssword1"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "155e11b5-b341-4011-b7b2-f7279ff445df",
                    Email = "user@test.com",
                    NormalizedEmail = "USER@TEST.COM",
                    NormalizedUserName= "USER@TEST.COM",
                    UserName= "user@test.com",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
                );
        }
    }
}