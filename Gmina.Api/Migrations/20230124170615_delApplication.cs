using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GminaApi.Migrations
{
    /// <inheritdoc />
    public partial class delApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersApplications_Applications_ApplicationId",
                table: "UsersApplications");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_UsersApplications_ApplicationId",
                table: "UsersApplications");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "UsersApplications");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationName",
                table: "UsersApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationName",
                table: "UsersApplications");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "UsersApplications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersApplications_ApplicationId",
                table: "UsersApplications",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersApplications_Applications_ApplicationId",
                table: "UsersApplications",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "ID");
        }
    }
}
