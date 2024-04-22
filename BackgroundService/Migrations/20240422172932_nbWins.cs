using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackgroundService.Migrations
{
    /// <inheritdoc />
    public partial class nbWins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NbClicks",
                table: "Player",
                newName: "NbWins");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NbWins",
                table: "Player",
                newName: "NbClicks");
        }
    }
}
