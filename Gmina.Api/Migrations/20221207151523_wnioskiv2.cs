using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GminaApi.Migrations
{
    /// <inheritdoc />
    public partial class wnioskiv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserApplicationValues",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParameterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserApplicationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserApplicationValues", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UsersApplications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClerkId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersApplications", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserApplicationValues");

            migrationBuilder.DropTable(
                name: "UsersApplications");
        }
    }
}
