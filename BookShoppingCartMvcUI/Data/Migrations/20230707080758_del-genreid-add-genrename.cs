using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShoppingCartMvcUI.Data.Migrations
{
    /// <inheritdoc />
    public partial class delgenreidaddgenrename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Genre");

            migrationBuilder.AddColumn<string>(
                name: "GenreName",
                table: "Genre",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreName",
                table: "Genre");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Genre",
                type: "int",
                maxLength: 40,
                nullable: false,
                defaultValue: 0);
        }
    }
}
