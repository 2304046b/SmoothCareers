using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmoothCareers.Migrations
{
    /// <inheritdoc />
    public partial class PopJobPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Employer",
                columns: new[] { "Id", "About", "CompanyName", "CreatedBy", "DateCreated", "DateUpdated", "Industry", "Location", "UpdatedBy" },
                values: new object[] { 1, null, "SmoothCareers Demo Pte Ltd", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", null });

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

            migrationBuilder.InsertData(
                table: "JobPost",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DatePosted", "DateUpdated", "Description", "EmployerId", "JobCategoryId", "JobTypeId", "Location", "Salary", "Title", "UpdatedBy", "WorkArrangementId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Build CRUD features with ASP.NET Core MVC, EF Core, SQL Server. Work with Git branching and code reviews.", 1, 1, 1, "Singapore (Tampines)", 4200m, "Junior Full-Stack Developer (.NET)", null, 2 },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Support automation workflows for Outlook/Excel and document processes. Basic regex and debugging is a plus.", 1, 1, 2, "Singapore (Remote)", 1200m, "RPA Developer (Intern) - UiPath", null, 3 },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean and analyze datasets using Python (Pandas) and build visual insights. Basic SQL required.", 1, 2, 1, "Singapore (Central)", 3800m, "Data Analyst (Entry-Level)", null, 2 },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create wireframes, user flows, and prototypes in Figma. Assist with usability testing and design systems.", 1, 3, 2, "Singapore (CBD)", 1200m, "UI/UX Designer (Intern)", null, 2 },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provide onsite support: Windows troubleshooting, printer issues, domain join, OneDrive/Outlook setup.", 1, 4, 1, "Singapore (Central)", 2800m, "IT Support Technician (Hospital)", null, 1 },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Execute test cases, report defects, and validate fixes. Exposure to test automation is a plus.", 1, 1, 3, "Singapore (East)", 3200m, "Software QA Tester (Contract)", null, 2 },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assist with networking tasks: IP config, connectivity troubleshooting, and basic device setup.", 1, 4, 1, "Singapore (North)", 3400m, "Network Support Engineer (Entry-Level)", null, 1 },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maintain site pages, fix UI bugs, and implement small features. HTML/CSS/JS and basic .NET helpful.", 1, 1, 4, "Singapore (Hybrid)", 2200m, "Web Developer (Part-Time)", null, 2 },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Support model training experiments, data preprocessing, and evaluation. Python required.", 1, 2, 3, "Singapore (Remote)", 4500m, "Junior ML Engineer (Contract)", null, 3 },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Support product planning, write user stories, coordinate with dev/design, and track feature delivery.", 1, 1, 1, "Singapore (CBD)", 3600m, "Product Associate (Tech)", null, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobPost",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employer",
                keyColumn: "Id",
                keyValue: 1);

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
