using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmoothCareers.Migrations
{
    /// <inheritdoc />
    public partial class AddSavedJobTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f86faed0-62f0-4b2c-9bed-fc050e247be3", "AQAAAAIAAYagAAAAECx8oQYOo2tccTbXn3QjwdcTmLK2tq5s0E8FPorlbiLDroBRdcvNA8OUwqXmw9BByg==", "e6615e2f-b4ba-41f3-a237-14ce401f83f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a2c3d4-e5f6-47a8-9b01-112233445566",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b41776b-5e40-4007-a555-e4eddd923d4a", "AQAAAAIAAYagAAAAEMU4biX35YmCWr5k4t4RTq+HpMamR0tJ+khr2OxB6zcmcORKRfd+ByjIFMSQTEHOlg==", "66b7728c-dbd2-4121-b3ee-e6c378a6b5fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2b3a4d5-e6f7-48b9-8c02-667788990011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c45d202-95df-4ac2-be86-051533c9e1c2", "AQAAAAIAAYagAAAAEI4HHZsp4GOdBl74RohRg0t6NHBz2ldutNSraLwXx+nskBFEgebwAT3VEMQbW8axFw==", "8585e878-d74c-40cf-93f2-d29e7e590818" });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6722), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6753), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6755), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6757), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6759), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6760), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6930), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6932), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6934), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6936), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6938), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(7259), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(7262), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(7267), new DateTime(2026, 1, 11, 0, 27, 44, 527, DateTimeKind.Local).AddTicks(7267) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1fbe51d-dc83-4939-bdda-5569b9283abe", "AQAAAAIAAYagAAAAEOBwRWPQyCfh46682Kbjv9BhSZ9RXeJdZ/5tBvjDFLFXIiHvAzxHLquNgBBstMQpAQ==", "e0f5bb60-7d94-455b-b5eb-bf6c070415cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a2c3d4-e5f6-47a8-9b01-112233445566",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9eee033-aa71-4be2-a974-f399735b010d", "AQAAAAIAAYagAAAAEOv9yAcPUEoEcauPoFTccX0siKAgiis9McmZyhj3q/KiO04fogBWIiWGCRLM9NUz3w==", "8cc070ac-15dc-4c7c-921d-2c90e5ffcbe4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2b3a4d5-e6f7-48b9-8c02-667788990011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d53824a-ee72-4c92-8174-92e11e862f41", "AQAAAAIAAYagAAAAEPX6d74gNMIomCW75afpZp6BnWMfwBcq2B0fO/upy7lAasGTsVsijKbtjYPkMBwLnQ==", "badf6c7d-29ed-4a09-969b-e7cc3a7dbd29" });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6309), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6327), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6329), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6331), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6333), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6334), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6566), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6568), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6570), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6571), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6573), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6920), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6922), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6924), new DateTime(2026, 1, 10, 22, 55, 15, 162, DateTimeKind.Local).AddTicks(6924) });
        }
    }
}
