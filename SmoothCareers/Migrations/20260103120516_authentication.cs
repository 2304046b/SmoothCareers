using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmoothCareers.Migrations
{
    /// <inheritdoc />
    public partial class authentication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Employer", "EMPLOYER" },
                    { "dd2bcf0c-20db-474f-8407-5a6b159518bd", null, "JobSeeker", "JOBSEEKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "8ff423a5-c2cf-45f5-8b07-59efa283a641", "admin@smoothcareers.com", true, null, null, false, null, "ADMIN@SMOOTHCAREERS.COM", "ADMIN@SMOOTHCAREERS.COM", "AQAAAAIAAYagAAAAELI8vfS1g7GiG+U7fFKvuPafoG4Sz8iMGq/eQTFmSMxpIU57Kn/W3u0QtMGrmzXjgw==", null, false, "feb229a1-6faa-4cc3-bf6d-6ba4a37dd65d", false, "admin@smoothcareers.com" },
                    { "b1a2c3d4-e5f6-47a8-9b01-112233445566", 0, "eb05034c-1ddf-4c1e-8101-c1d6b86427db", "employer@smoothcareers.com", true, null, null, false, null, "EMPLOYER@SMOOTHCAREERS.COM", "EMPLOYER@SMOOTHCAREERS.COM", "AQAAAAIAAYagAAAAENFToZYTSiXCNATZLiSEx4dQFp8jvp3k5koWDejgHKffSrg6Q3+FgsoV99IizhGtIQ==", null, false, "4fec309e-185d-4b41-b0c8-13adc8b0789b", false, "employer@smoothcareers.com" },
                    { "c2b3a4d5-e6f7-48b9-8c02-667788990011", 0, "8d975618-4044-4c4c-9b7d-e7ef5ba4a313", "jobseeker@smoothcareers.com", true, null, null, false, null, "JOBSEEKER@SMOOTHCAREERS.COM", "JOBSEEKER@SMOOTHCAREERS.COM", "AQAAAAIAAYagAAAAEGKRf+38yS8G1MvDTGKylUQV8foZA8z+XPMcq4rtWZ/hVHB19gUOv+eq8cD4ucvv9g==", null, false, "e8708342-ddc5-4d8c-baaa-2912f3c5114a", false, "jobseeker@smoothcareers.com" }
                });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6958), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6985), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6990), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6994), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6998), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7001), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7507), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7513), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7517), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7520), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7523), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(8663), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(8673), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(8689), new DateTime(2026, 1, 3, 20, 5, 14, 336, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", "b1a2c3d4-e5f6-47a8-9b01-112233445566" },
                    { "dd2bcf0c-20db-474f-8407-5a6b159518bd", "c2b3a4d5-e6f7-48b9-8c02-667788990011" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd2bcf0c-20db-474f-8407-5a6b159518bc", "b1a2c3d4-e5f6-47a8-9b01-112233445566" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd2bcf0c-20db-474f-8407-5a6b159518bd", "c2b3a4d5-e6f7-48b9-8c02-667788990011" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2bcf0c-20db-474f-8407-5a6b159518bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd2bcf0c-20db-474f-8407-5a6b159518bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a2c3d4-e5f6-47a8-9b01-112233445566");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2b3a4d5-e6f7-48b9-8c02-667788990011");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5296), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5325), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5330), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5336), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5341), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5346), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6015), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6023), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6028), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6032), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6037), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6511), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6518), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6523), new DateTime(2026, 1, 3, 15, 22, 22, 763, DateTimeKind.Local).AddTicks(6524) });
        }
    }
}
