using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmoothCareers.Migrations
{
    /// <inheritdoc />
    public partial class JobPostEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobCategoryId",
                table: "JobPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobTypeId",
                table: "JobPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkArrangementId",
                table: "JobPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "JobCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkArrangement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkArrangement", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_JobCategoryId",
                table: "JobPost",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_JobTypeId",
                table: "JobPost",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_WorkArrangementId",
                table: "JobPost",
                column: "WorkArrangementId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_JobCategory_JobCategoryId",
                table: "JobPost",
                column: "JobCategoryId",
                principalTable: "JobCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_JobType_JobTypeId",
                table: "JobPost",
                column: "JobTypeId",
                principalTable: "JobType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_WorkArrangement_WorkArrangementId",
                table: "JobPost",
                column: "WorkArrangementId",
                principalTable: "WorkArrangement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_JobCategory_JobCategoryId",
                table: "JobPost");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_JobType_JobTypeId",
                table: "JobPost");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_WorkArrangement_WorkArrangementId",
                table: "JobPost");

            migrationBuilder.DropTable(
                name: "JobCategory");

            migrationBuilder.DropTable(
                name: "JobType");

            migrationBuilder.DropTable(
                name: "WorkArrangement");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_JobCategoryId",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_JobTypeId",
                table: "JobPost");

            migrationBuilder.DropIndex(
                name: "IX_JobPost_WorkArrangementId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "JobCategoryId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "JobTypeId",
                table: "JobPost");

            migrationBuilder.DropColumn(
                name: "WorkArrangementId",
                table: "JobPost");
        }
    }
}
