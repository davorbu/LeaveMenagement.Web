using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveMenagement.Web.Data.Migrations
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
                    { "1779760b-612f-5f60-b4b0-538a53ab1dc9", "df1c3343-329f-4342-aa8b-ced5d943cb96", "Administrator", "ADMINISTRATOR" },
                    { "1889760b-912f-6f60-b4b0-649a53ab1dc9", "39b5ba7d-a750-491a-ba3d-0e0b41c4d02d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1669760b-612f-4f60-b4b0-427a53ab1dc9", 0, "773877c2-0e10-4cb2-92b0-1a12f3e7afee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEGB5Rxiic98qmzHQLBjgSN/AM5dQ+UFLOcyZeFg8hWEfYBXNTBoZ8q56Z0wfwMYVJw==", null, false, "a9f44e6a-3f50-4bc4-8efc-08c9a02b1f4a", null, false, null },
                    { "1779760b-612f-5f60-b4b0-538a53ab1dc9", 0, "d4431635-ea81-45d2-bbdb-695ac0b389aa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "AdminTest", "Test", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEGYP1YEbP5rC2+dx/Fy3l9/Fr6dcDiVlm2pw2XXKSH9cyNup0ydEaPy7+NlRGXDzWA==", null, false, "c4f89b7c-7399-41e6-a003-099a2044ac0b", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1889760b-912f-6f60-b4b0-649a53ab1dc9", "1669760b-612f-4f60-b4b0-427a53ab1dc9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1779760b-612f-5f60-b4b0-538a53ab1dc9", "1779760b-612f-5f60-b4b0-538a53ab1dc9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1889760b-912f-6f60-b4b0-649a53ab1dc9", "1669760b-612f-4f60-b4b0-427a53ab1dc9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1779760b-612f-5f60-b4b0-538a53ab1dc9", "1779760b-612f-5f60-b4b0-538a53ab1dc9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1779760b-612f-5f60-b4b0-538a53ab1dc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1889760b-912f-6f60-b4b0-649a53ab1dc9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1669760b-612f-4f60-b4b0-427a53ab1dc9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1779760b-612f-5f60-b4b0-538a53ab1dc9");
        }
    }
}
