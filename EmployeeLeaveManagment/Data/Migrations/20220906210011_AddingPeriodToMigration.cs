using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeaveManagment.Data.Migrations
{
    public partial class AddingPeriodToMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b10b5-b641-4036-b6b0-f7719ff456df",
                column: "ConcurrencyStamp",
                value: "a1873b08-1e50-45e6-9caa-e3ce6096ace1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b13b5-b641-4036-b7b2-f7719ff446df",
                column: "ConcurrencyStamp",
                value: "629771f0-26cd-4dd1-bc01-0b583e013442");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "155e11b5-b341-4011-b7b2-f7279ff445df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "282371bd-feaa-476c-9738-3b2102d78914", "AQAAAAEAACcQAAAAEKM4++R4NJmkHj0y49q046kx6Ls7ODb/PFpvWKd1FLYIhoDe9kt/tjqduPLb8nbthw==", "0c991b82-1df5-4442-8364-2f41f287aafe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159e13b5-b341-4034-b7b2-f7779ff445df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17309535-62e4-4ef2-b138-2dabd0a140b4", "AQAAAAEAACcQAAAAEAfZaPxQ5ywxjE0AlDVtMUARhsifSGbNfp5AAsjkcJgPSeATe1YJiMmkn74dwRMcCg==", "f66a58c0-509c-47d4-80fb-b090094ac1cf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bebf630-d1db-4269-a45b-28a7893d30d8", "AQAAAAEAACcQAAAAEAZD7/sGOVYXsrJogTdo0NZoSBtXFZL+hMHJ5UtT3QXwhLkJ9/zRghnc5pIvLCypDA==", "8f3c55f0-8143-492f-b6c1-13438f519d64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159e13b5-b341-4034-b7b2-f7779ff445df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6a169f7-ca66-4469-af87-d285a469c477", "AQAAAAEAACcQAAAAECS9WRgdfKXfgD8c3kkSDL67lm0mkcIKSzf93xEhnaB8uHetBzlTqyH/OLMwwVkp9A==", "a03554bb-0520-4373-bcc4-4c661f34c7d3" });
        }
    }
}
