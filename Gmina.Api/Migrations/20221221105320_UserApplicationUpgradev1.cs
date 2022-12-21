using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GminaApi.Migrations
{
    /// <inheritdoc />
    public partial class UserApplicationUpgradev1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "UsersApplications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersApplications_Applications_ApplicationId",
                table: "UsersApplications");

            migrationBuilder.DropIndex(
                name: "IX_UsersApplications_ApplicationId",
                table: "UsersApplications");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "UsersApplications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
