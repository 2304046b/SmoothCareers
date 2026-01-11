using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmoothCareers.Migrations
{
    /// <inheritdoc />
    public partial class AddJobSeekerDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SavedJob");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "SavedJob");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "SavedJob");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SavedJob");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b65b72bf-cdae-49b0-a0cc-fcb149f33cdb", "AQAAAAIAAYagAAAAEE3CX4S7hGqhMoof6Lwiz0sftqbpK8LIPjkvT5wnMRbYyQX0++Rer9SzHpKP3h3JHw==", "01b37684-d0b2-411e-b28b-6f4b03f9174a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1a2c3d4-e5f6-47a8-9b01-112233445566",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f899f22-3c1b-459b-8da8-9d2dfcd0f176", "AQAAAAIAAYagAAAAEExOteglzeDmeYdxWze0vCIY4G7VIEJFHW8kFPciSD1wTfMsA0po2j36tvBl/l8LBQ==", "4f8e07bc-c8a4-4f14-b43c-f349a47388c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2b3a4d5-e6f7-48b9-8c02-667788990011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40291fdf-36ff-4d00-850b-73630af9413a", "AQAAAAIAAYagAAAAEB7xN8w87eIYJLqiqcz+CPj7iI8XviepdLZQSz/6KxHA8xVoy/8CVdF5Y1M+wvaX4Q==", "b61a0610-8163-45f8-ac39-e3ebc197be2b" });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8871), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8883), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8885), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8887), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8889), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "JobCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8890), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9051), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9053), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9055), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9057), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "JobType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9058), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9467), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9469), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "WorkArrangement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9470), new DateTime(2026, 1, 11, 12, 56, 0, 591, DateTimeKind.Local).AddTicks(9471) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SavedJob",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "SavedJob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "SavedJob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "SavedJob",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
