using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GminaApi.Migrations
{
    /// <inheritdoc />
    public partial class imgURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgURL",
                table: "EventEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgURL",
                table: "EventEntity");
        }
    }
}
