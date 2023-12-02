using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class CreateDBagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesBooks_Categories_CategorieId",
                table: "CategoriesBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesBooks_Category_CategorieId",
                table: "CategoriesBooks",
                column: "CategorieId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesBooks_Category_CategorieId",
                table: "CategoriesBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesBooks_Categories_CategorieId",
                table: "CategoriesBooks",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
