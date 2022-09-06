using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeaveManagment.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "159b10b5-b641-4036-b6b0-f7719ff456df", "b3a4b7fc-4290-461d-ab29-40ace08a5517", "User", "USER" },
                    { "159b13b5-b641-4036-b7b2-f7719ff446df", "29531e47-0d71-42f2-b070-c3ca2f3992cf", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "155e11b5-b341-4011-b7b2-f7279ff445df", 0, "42594b3e-ff04-470e-97f0-4fb5df95b199", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "System", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEA2nQQAPaZ/k0IphKqVohWAx41qksPs+n0CkQCghYPcyVcsKtyVT3n2tt2Hik081vQ==", null, false, "34ee25f5-aa5f-4929-a456-dc765f4297e7", null, false, null },
                    { "159e13b5-b341-4034-b7b2-f7779ff445df", 0, "6249af46-07c8-4ee6-aace-d0f461b06f6b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEMRxYiIVDwFS00RzRbNYPkgKYDd4cLDo+H0naj6VClPuJrhVgB+qEBcwY3IBpPak1g==", null, false, "96c8db23-f7e7-41a4-8e75-cc4c70ff2767", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "159b10b5-b641-4036-b6b0-f7719ff456df", "155e11b5-b341-4011-b7b2-f7279ff445df" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "159b13b5-b641-4036-b7b2-f7719ff446df", "159e13b5-b341-4034-b7b2-f7779ff445df" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "159b10b5-b641-4036-b6b0-f7719ff456df", "155e11b5-b341-4011-b7b2-f7279ff445df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "159b13b5-b641-4036-b7b2-f7719ff446df", "159e13b5-b341-4034-b7b2-f7779ff445df" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b10b5-b641-4036-b6b0-f7719ff456df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b13b5-b641-4036-b7b2-f7719ff446df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "155e11b5-b341-4011-b7b2-f7279ff445df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159e13b5-b341-4034-b7b2-f7779ff445df");
        }
    }
}
