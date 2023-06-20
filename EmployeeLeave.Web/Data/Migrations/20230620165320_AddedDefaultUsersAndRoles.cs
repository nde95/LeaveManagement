using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeave.Web.Data.Migrations
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
                    { "c42c2f4f-11d4-435e-a468-05919ff33347", "8c1f08d1-f65a-4e85-935f-56369f512535", "Administrator", "ADMINISTRATOR" },
                    { "c42c3f5f-11d4-435e-a468-05919ff33347", "48e17b22-da98-4f0d-9f9a-d338d43379ca", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2313c553-9fc2-4d67-aade-3e8eb6a50ab0", 0, "6aedb9f3-ae77-43cf-956d-d5d853ad65f1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAECD7bNW5g5oe1wFRFALAGCXO2PoHMu09kNote2kE7n+jMO+Ha1snA30N7GXxPfoWrw==", null, false, "70eb2c77-c6c5-4176-8fa2-67554a10c8f5", null, false, null },
                    { "c42c2f4f-11d4-435e-a468-05919f513347", 0, "add88dd2-83da-44bb-80b6-6cfaefd6111e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEKfT2/ydKVf/ktxMBULlH2jheU+20e7x96u1Kb9JwfROhtklvHuUArWpllmj1Wwfaw==", null, false, "d73ba6a3-b51f-4a38-ab03-0ebae3c41de3", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c42c2f4f-11d4-435e-a468-05919ff33347", "2313c553-9fc2-4d67-aade-3e8eb6a50ab0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c42c3f5f-11d4-435e-a468-05919ff33347", "c42c2f4f-11d4-435e-a468-05919f513347" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c42c2f4f-11d4-435e-a468-05919ff33347", "2313c553-9fc2-4d67-aade-3e8eb6a50ab0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c42c3f5f-11d4-435e-a468-05919ff33347", "c42c2f4f-11d4-435e-a468-05919f513347" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919ff33347");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c42c3f5f-11d4-435e-a468-05919ff33347");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2313c553-9fc2-4d67-aade-3e8eb6a50ab0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c42c2f4f-11d4-435e-a468-05919f513347");
        }
    }
}
