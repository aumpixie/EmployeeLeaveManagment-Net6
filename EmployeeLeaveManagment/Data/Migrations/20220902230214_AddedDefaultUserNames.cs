using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeaveManagment.Data.Migrations
{
    public partial class AddedDefaultUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b10b5-b641-4036-b6b0-f7719ff456df",
                column: "ConcurrencyStamp",
                value: "e72ff718-a895-4a64-8080-d2a7f162d527");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b13b5-b641-4036-b7b2-f7719ff446df",
                column: "ConcurrencyStamp",
                value: "d39230ea-90a0-40e7-8a53-619145577391");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "155e11b5-b341-4011-b7b2-f7279ff445df",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9bebf630-d1db-4269-a45b-28a7893d30d8", true, "USER@TEST.COM", "AQAAAAEAACcQAAAAEAZD7/sGOVYXsrJogTdo0NZoSBtXFZL+hMHJ5UtT3QXwhLkJ9/zRghnc5pIvLCypDA==", "8f3c55f0-8143-492f-b6c1-13438f519d64", "user@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159e13b5-b341-4034-b7b2-f7779ff445df",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a6a169f7-ca66-4469-af87-d285a469c477", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAECS9WRgdfKXfgD8c3kkSDL67lm0mkcIKSzf93xEhnaB8uHetBzlTqyH/OLMwwVkp9A==", "a03554bb-0520-4373-bcc4-4c661f34c7d3", "admin@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b10b5-b641-4036-b6b0-f7719ff456df",
                column: "ConcurrencyStamp",
                value: "b3a4b7fc-4290-461d-ab29-40ace08a5517");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b13b5-b641-4036-b7b2-f7719ff446df",
                column: "ConcurrencyStamp",
                value: "29531e47-0d71-42f2-b070-c3ca2f3992cf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "155e11b5-b341-4011-b7b2-f7279ff445df",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "42594b3e-ff04-470e-97f0-4fb5df95b199", false, null, "AQAAAAEAACcQAAAAEA2nQQAPaZ/k0IphKqVohWAx41qksPs+n0CkQCghYPcyVcsKtyVT3n2tt2Hik081vQ==", "34ee25f5-aa5f-4929-a456-dc765f4297e7", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159e13b5-b341-4034-b7b2-f7779ff445df",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6249af46-07c8-4ee6-aace-d0f461b06f6b", false, null, "AQAAAAEAACcQAAAAEMRxYiIVDwFS00RzRbNYPkgKYDd4cLDo+H0naj6VClPuJrhVgB+qEBcwY3IBpPak1g==", "96c8db23-f7e7-41a4-8e75-cc4c70ff2767", null });
        }
    }
}
