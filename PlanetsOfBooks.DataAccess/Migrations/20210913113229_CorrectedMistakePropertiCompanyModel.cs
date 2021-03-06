using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanetOfBooks.DataAccess.Migrations
{
    public partial class CorrectedMistakePropertiCompanyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
