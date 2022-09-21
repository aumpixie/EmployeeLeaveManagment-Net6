using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeaveManagment.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b10b5-b641-4036-b6b0-f7719ff456df",
                column: "ConcurrencyStamp",
                value: "a9ec5e18-7e3a-46bd-bff7-34f47cf19294");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b13b5-b641-4036-b7b2-f7719ff446df",
                column: "ConcurrencyStamp",
                value: "99305ca3-6394-493a-a1b7-1958546c6331");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "155e11b5-b341-4011-b7b2-f7279ff445df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9adc6993-3f91-460d-a43c-77ab97129024", "AQAAAAEAACcQAAAAEKR4jwG82bZtQIAsEHHdwefdWME5/HermiLVG29NkIyf9S3x6jkxWK9ju9UzKnsDgg==", "66539324-2a22-48f9-a708-5059c0d2c9f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159e13b5-b341-4034-b7b2-f7779ff445df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebe0c68e-b66a-4d10-ba92-30b7204d7c37", "AQAAAAEAACcQAAAAEB5hFhao6d6YPUVJXDLQNyzXQKPBE1yvs8Ndy4J6jcB9irv/9zCAOOlpHii11lIqaA==", "c26c7eee-bb2f-4049-903c-12661fee030f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b10b5-b641-4036-b6b0-f7719ff456df",
                column: "ConcurrencyStamp",
                value: "dc5950a0-7af1-4da1-8f51-7d18ed61d3f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "159b13b5-b641-4036-b7b2-f7719ff446df",
                column: "ConcurrencyStamp",
                value: "2bebfd9c-f0d4-48a3-824e-2bb43c2874cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "155e11b5-b341-4011-b7b2-f7279ff445df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab468457-4a59-4693-8077-198f5a2ec7f3", "AQAAAAEAACcQAAAAEBq9DwSOQZiXpP5SV6H/0tarUd076dT77j4hUqvkfSgXW5y3zPnJI9h86P1PJN2I9Q==", "39ad1fbf-e540-4d59-b9a5-35bf3d5e7c60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159e13b5-b341-4034-b7b2-f7779ff445df",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f991d8d-75c6-4e3f-90e6-4071c70f234f", "AQAAAAEAACcQAAAAEIdhOOTOVMAgDOl39RAzv9WDrqVfG4WT1mC5EQmuRThkFkVoi4Z5ORcY4y2npcH8Iw==", "60455f1c-21d4-4a8c-b860-fc8f0ee6c0ea" });
        }
    }
}
