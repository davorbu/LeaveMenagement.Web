using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveMenagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
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
                keyValue: "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                column: "ConcurrencyStamp",
                value: "06c527b5-a1c1-446d-9c6f-6f16fce2ffaf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1889760b-912f-6f60-b4b0-649a53ab1dc9",
                column: "ConcurrencyStamp",
                value: "c1d59450-6d82-4dbc-81b4-df9ac356d28c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1669760b-612f-4f60-b4b0-427a53ab1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2931cbdf-c54e-4546-b051-25fcf32a5270", "AQAAAAEAACcQAAAAED/UHEJSdrDDjvuFSrG623rwcwfzksKGV2daqR9YLmh+cwY462cAyIXrosD62rLP9g==", "ea84d49b-fa2d-4643-8c4b-1f8b1833b820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59bfb23e-bba0-43cf-8251-0e8898868876", "AQAAAAEAACcQAAAAENE2n01yGpLb8vFbdrmb5PhGoa4JEzcSiP2hMU1y4tIcBOf/io6Bnc4+2zCUIsaCvg==", "3ec956b7-939a-43a3-931c-4fdaa6b5b31d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2fa9e1a-8862-4a18-9a33-e92765ceae07", "AQAAAAEAACcQAAAAECiBA0BIpuF4rk9vhj0Lq3KoI4GUUCyn3X6CTWMRAK515SSTxFufVUPJOndeCEDNzw==", "b7d4fd6d-46c1-4b9f-8df5-935c0a417607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1779760b-612f-5f60-b4b0-538a53ab1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55a323a9-8b07-4d4e-a272-630c3eaa37c0", "AQAAAAEAACcQAAAAEOWXxKXQlUcDVlE0nCyyvnxK5Z8Z3xe33zLmPPTLQDt7GSZUQMMioOMB3dxKudrTzg==", "f0c8ef85-28bb-48fd-ad66-6602f00ff2ce" });
        }
    }
}
