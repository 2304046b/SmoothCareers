using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmoothCareers.Migrations
{
    /// <inheritdoc />
    public partial class applicationdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b7dc34a-aef5-4139-919c-2b5dcfe5f091", "AQAAAAIAAYagAAAAEOhzr7JsoIiEwxy9SmcpeHnD5Cvyz/qqpzQiFLhojPuBpi/JLeKau2MRm6RnV+F1Qw==", "edee5ba9-e784-4f18-9877-9d83ee7fb963" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a2c3d4-e5f6-47a8-9b01-112233445566",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba8805c5-57fe-436b-a666-84378ee63a17", "AQAAAAIAAYagAAAAEFig6YkJ47iqOKRKH9E23Uu98StwhxMKv4Hvk96kDSAt5iq/jxAR/X/rTqcXMTm1RQ==", "7c4c7250-afce-4405-8957-0a9bba3d08e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2b3a4d5-e6f7-48b9-8c02-667788990011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feeda2b6-e67d-4f7f-969b-e3321df062e4", "AQAAAAIAAYagAAAAEEePZj6jCWW7pJy5bpbh/U3/yI30XFgDUvWMmJvOJmSS/zmZtf4rAQyn5sLa4aU9sQ==", "bc37b72b-7efe-482f-bb4b-c125e10a8c71" });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1578), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1617), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1622), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1627), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1630), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1634), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2197), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2204), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2207), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2211), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2214), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2562), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2571), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2599), new DateTime(2026, 1, 6, 15, 35, 28, 560, DateTimeKind.Local).AddTicks(2601) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ff423a5-c2cf-45f5-8b07-59efa283a641", "AQAAAAIAAYagAAAAELI8vfS1g7GiG+U7fFKvuPafoG4Sz8iMGq/eQTFmSMxpIU57Kn/W3u0QtMGrmzXjgw==", "feb229a1-6faa-4cc3-bf6d-6ba4a37dd65d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a2c3d4-e5f6-47a8-9b01-112233445566",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb05034c-1ddf-4c1e-8101-c1d6b86427db", "AQAAAAIAAYagAAAAENFToZYTSiXCNATZLiSEx4dQFp8jvp3k5koWDejgHKffSrg6Q3+FgsoV99IizhGtIQ==", "4fec309e-185d-4b41-b0c8-13adc8b0789b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2b3a4d5-e6f7-48b9-8c02-667788990011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d975618-4044-4c4c-9b7d-e7ef5ba4a313", "AQAAAAIAAYagAAAAEGKRf+38yS8G1MvDTGKylUQV8foZA8z+XPMcq4rtWZ/hVHB19gUOv+eq8cD4ucvv9g==", "e8708342-ddc5-4d8c-baaa-2912f3c5114a" });

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
        }
    }
}
