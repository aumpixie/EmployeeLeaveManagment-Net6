using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeaveManagment.Data.Migrations
{
    public partial class AddedLeaveRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Canceled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
