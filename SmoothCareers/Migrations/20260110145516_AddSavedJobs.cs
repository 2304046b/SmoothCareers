using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmoothCareers.Migrations
{
    /// <inheritdoc />
    public partial class AddSavedJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SavedJob",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobPostId = table.Column<int>(type: "int", nullable: false),
                    SavedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSaved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedJob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedJob_JobPost_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SavedJob_JobPostId",
                table: "SavedJob",
                column: "JobPostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedJob");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af36fff0-97aa-4957-9eb3-114ef351f478", "AQAAAAIAAYagAAAAEEgTse6JtfjsYKwRpTiAlMpQTBJy4meEn5uUPmsdKwUuflavYjpL1owdM44BTCktdg==", "a9d02314-b7e2-4e1f-8aea-3172ecdfd7bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a2c3d4-e5f6-47a8-9b01-112233445566",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbecd078-0569-408f-8f63-e55ef72a0d9b", "AQAAAAIAAYagAAAAEHJpSSh59OKVQFWjrl+isQUEcvXCYb8CF/EbA9vNilJq3P7we7sPJCDXv+htqYfStg==", "eb349e2b-07d1-4830-a697-b5c8bdb72d80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2b3a4d5-e6f7-48b9-8c02-667788990011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf456b53-61cc-43dc-8b8f-500b7ad5800f", "AQAAAAIAAYagAAAAEG6kiv0YXsen/cKkR4mlsRasA4N19kXB/dACcstCew984nOM7Z6tS117eu4avr2ryA==", "70908dc7-ba17-4889-91ef-e06b3e82c4c3" });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(6995), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7015), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7017), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7019), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7020), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7022), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7426), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7428), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7430), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7431), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7433), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7791), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7794), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7795), new DateTime(2026, 1, 7, 1, 12, 14, 81, DateTimeKind.Local).AddTicks(7796) });
        }
    }
}
