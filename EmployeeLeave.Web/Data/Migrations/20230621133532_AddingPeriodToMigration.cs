using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeave.Web.Data.Migrations
{
    public partial class AddingPeriodToMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919ff33347",
                column: "ConcurrencyStamp",
                value: "e85dbf1e-d2a5-4de9-850c-801bcd5b3dff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42c3f5f-11d4-435e-a468-05919ff33347",
                column: "ConcurrencyStamp",
                value: "85dd822b-1790-4c16-a9f4-e533c5821f78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2313c553-9fc2-4d67-aade-3e8eb6a50ab0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36a87fa1-642c-4af1-a8c6-afdc9e5e1d9f", "AQAAAAEAACcQAAAAEFKEhbBlnO/khWryizHc1PHQdJ86fTvehSw+5xcTv82HbX2ZRt2m6gb2aOlBdMIo6g==", "151894ed-5afa-4f20-979a-7c4c6f69c548" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919f513347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fcf68e8-69d2-48e0-a9dc-3a2f7bba74b3", "AQAAAAEAACcQAAAAECp+bQfMKCN0eSgncbI3WUx0AtH/JuHmRFRTKgjKVRmtT8qeuLBrHJ4K4pUnPGVK5A==", "23f57256-5dea-48cd-8830-6af69dcffabe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34285dbc-06ef-4a6a-800f-608797e9467a", "AQAAAAEAACcQAAAAEFmwIn/hTmbksOlNurzDFjjjJO4a6nyMaUc7Y3xbmH2rtJJYg0S6CTWmMRFYcAZBRA==", "0c71b15c-dce4-4b9c-8fa9-a6dbd8644d05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919f513347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b43ee5e-c963-45c9-9159-b278afc3870c", "AQAAAAEAACcQAAAAEIjiZe+QPyDiXQGGXHXcI58knS8sUMdOjmyXIlwoO0jUl/PvBZo3bXJ5GRe6dKxDtQ==", "c1dfe4b8-142b-4b40-8cd8-1d4e9375a690" });
        }
    }
}
