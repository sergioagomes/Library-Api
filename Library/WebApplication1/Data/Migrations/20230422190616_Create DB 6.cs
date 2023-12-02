using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class CreateDB6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesBooks_Category_CategorieId",
                table: "CategoriesBooks");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_CategoriesBooks_CategorieId",
                table: "CategoriesBooks");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CategoriesBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesBooks_CategoryId",
                table: "CategoriesBooks",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesBooks_Genres_CategoryId",
                table: "CategoriesBooks",
                column: "CategoryId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesBooks_Genres_CategoryId",
                table: "CategoriesBooks");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_CategoriesBooks_CategoryId",
                table: "CategoriesBooks");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CategoriesBooks");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesBooks_CategorieId",
                table: "CategoriesBooks",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesBooks_Category_CategorieId",
                table: "CategoriesBooks",
                column: "CategorieId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
