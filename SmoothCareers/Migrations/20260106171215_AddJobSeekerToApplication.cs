using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmoothCareers.Migrations
{
    /// <inheritdoc />
    public partial class AddJobSeekerToApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d4cb930-4e57-4085-82bd-32b4e43aede2", "AQAAAAIAAYagAAAAEBzA+T8+z1Mbs1W42vAgJDnFdqjJbFmDL/0gLXVbg6cfNpfFjidzUwgPvsfAL8p4fg==", "ede2d623-06ce-4286-a172-c1aaa406cf08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a2c3d4-e5f6-47a8-9b01-112233445566",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "562a8427-8408-489a-b507-70b4814b6999", "AQAAAAIAAYagAAAAEGuiE6GlORrpTKNiVyUupKm2Yf79lRe5giIeRAyUq4DgH4J8HRomacwgvWEWafDYhg==", "b916beea-819a-4d69-a082-692b7057be54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2b3a4d5-e6f7-48b9-8c02-667788990011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97d54c01-cee0-463e-8b92-d1f756e80933", "AQAAAAIAAYagAAAAEIfiNWOZaftLb/Ee5rSs6ERIj2bWDckM5ReurkS3M1RZL9MXenxGFfLLzkS6n8bvAQ==", "77bf8566-adcb-496f-901d-d53e4d6ce839" });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3161), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3178), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3180), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3182), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3184), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3185), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3572), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3576), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3578), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3580), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3582), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(4039), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(4041), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(4043), new DateTime(2026, 1, 5, 18, 11, 5, 480, DateTimeKind.Local).AddTicks(4044) });
        }
    }
}
