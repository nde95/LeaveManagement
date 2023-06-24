using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeave.Web.Data.Migrations
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
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
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
                keyValue: "c42c2f4f-11d4-435e-a468-05919ff33347",
                column: "ConcurrencyStamp",
                value: "351abbef-6e14-4644-9b5a-ee22ea2c1f76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42c3f5f-11d4-435e-a468-05919ff33347",
                column: "ConcurrencyStamp",
                value: "44d529ad-a12d-4071-9f44-f4d080d5a6e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2313c553-9fc2-4d67-aade-3e8eb6a50ab0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf94e87e-8e5c-4b44-94c5-32c02bc7ec6a", "AQAAAAEAACcQAAAAENtzULWD7LKd2n2d+FtbK2cMZgvKyruL9z0iGeWipynQMSYchddmltDXXoL+Fz6tdw==", "903ce5ca-59a4-4dc3-82e2-4edcfbba2951" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919f513347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29a93d6d-3e89-45e8-ab55-8842646345cf", "AQAAAAEAACcQAAAAEOyTQsGyzbUb5Lr+ZuDjautndA5NYuvys0GU5ElbY3VaK/YR+9YR5SptbwMPSoYEYg==", "fb29ddf2-c1c1-47fd-985e-1fa50c9b0362" });

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
    }
}
