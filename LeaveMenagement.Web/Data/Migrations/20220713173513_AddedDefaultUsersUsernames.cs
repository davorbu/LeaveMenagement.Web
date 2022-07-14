using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveMenagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                column: "ConcurrencyStamp",
                value: "7aa47203-8550-45ea-985a-e2b6415cb7ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1889760b-912f-6f60-b4b0-649a53ab1dc9",
                column: "ConcurrencyStamp",
                value: "f1047363-daf3-4ac7-9d80-b08a1b2d2fa2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1669760b-612f-4f60-b4b0-427a53ab1dc9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2fa9e1a-8862-4a18-9a33-e92765ceae07", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAECiBA0BIpuF4rk9vhj0Lq3KoI4GUUCyn3X6CTWMRAK515SSTxFufVUPJOndeCEDNzw==", "b7d4fd6d-46c1-4b9f-8df5-935c0a417607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55a323a9-8b07-4d4e-a272-630c3eaa37c0", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEOWXxKXQlUcDVlE0nCyyvnxK5Z8Z3xe33zLmPPTLQDt7GSZUQMMioOMB3dxKudrTzg==", "f0c8ef85-28bb-48fd-ad66-6602f00ff2ce" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                column: "ConcurrencyStamp",
                value: "df1c3343-329f-4342-aa8b-ced5d943cb96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1889760b-912f-6f60-b4b0-649a53ab1dc9",
                column: "ConcurrencyStamp",
                value: "39b5ba7d-a750-491a-ba3d-0e0b41c4d02d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1669760b-612f-4f60-b4b0-427a53ab1dc9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "773877c2-0e10-4cb2-92b0-1a12f3e7afee", false, null, "AQAAAAEAACcQAAAAEGB5Rxiic98qmzHQLBjgSN/AM5dQ+UFLOcyZeFg8hWEfYBXNTBoZ8q56Z0wfwMYVJw==", "a9f44e6a-3f50-4bc4-8efc-08c9a02b1f4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4431635-ea81-45d2-bbdb-695ac0b389aa", false, null, "AQAAAAEAACcQAAAAEGYP1YEbP5rC2+dx/Fy3l9/Fr6dcDiVlm2pw2XXKSH9cyNup0ydEaPy7+NlRGXDzWA==", "c4f89b7c-7399-41e6-a003-099a2044ac0b" });
        }
    }
}
