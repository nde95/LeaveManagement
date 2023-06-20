using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeave.Web.Data.Migrations
{
    public partial class AddedDefaultUserUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919ff33347",
                column: "ConcurrencyStamp",
                value: "5597ab80-0163-41be-a275-a1de175e9022");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42c3f5f-11d4-435e-a468-05919ff33347",
                column: "ConcurrencyStamp",
                value: "85161d2e-cd42-46e1-95fe-8753191e674b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2313c553-9fc2-4d67-aade-3e8eb6a50ab0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "34285dbc-06ef-4a6a-800f-608797e9467a", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFmwIn/hTmbksOlNurzDFjjjJO4a6nyMaUc7Y3xbmH2rtJJYg0S6CTWmMRFYcAZBRA==", "0c71b15c-dce4-4b9c-8fa9-a6dbd8644d05", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919f513347",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8b43ee5e-c963-45c9-9159-b278afc3870c", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIjiZe+QPyDiXQGGXHXcI58knS8sUMdOjmyXIlwoO0jUl/PvBZo3bXJ5GRe6dKxDtQ==", "c1dfe4b8-142b-4b40-8cd8-1d4e9375a690", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919ff33347",
                column: "ConcurrencyStamp",
                value: "8c1f08d1-f65a-4e85-935f-56369f512535");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42c3f5f-11d4-435e-a468-05919ff33347",
                column: "ConcurrencyStamp",
                value: "48e17b22-da98-4f0d-9f9a-d338d43379ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2313c553-9fc2-4d67-aade-3e8eb6a50ab0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6aedb9f3-ae77-43cf-956d-d5d853ad65f1", false, null, "AQAAAAEAACcQAAAAECD7bNW5g5oe1wFRFALAGCXO2PoHMu09kNote2kE7n+jMO+Ha1snA30N7GXxPfoWrw==", "70eb2c77-c6c5-4176-8fa2-67554a10c8f5", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919f513347",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "add88dd2-83da-44bb-80b6-6cfaefd6111e", false, null, "AQAAAAEAACcQAAAAEKfT2/ydKVf/ktxMBULlH2jheU+20e7x96u1Kb9JwfROhtklvHuUArWpllmj1Wwfaw==", "d73ba6a3-b51f-4a38-ab03-0ebae3c41de3", null });
        }
    }
}
