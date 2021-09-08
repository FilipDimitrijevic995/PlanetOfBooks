using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanetOfBooks.DataAccess.Migrations
{
    public partial class ChangedTitleNameInProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tite",
                table: "Products",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "Tite");
        }
    }
}
