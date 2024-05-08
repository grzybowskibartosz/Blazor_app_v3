using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_app_v3.Migrations
{
    /// <inheritdoc />
    public partial class _07052024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rate_num",
                table: "Movie",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate_num",
                table: "Movie");
        }
    }
}
