using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class GenreGenreBook1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId1",
                table: "GenreBook",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GenreName",
                table: "Books",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GenreBook_BookId1",
                table: "GenreBook",
                column: "BookId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreBook_Books_BookId1",
                table: "GenreBook",
                column: "BookId1",
                principalTable: "Books",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreBook_Books_BookId1",
                table: "GenreBook");

            migrationBuilder.DropIndex(
                name: "IX_GenreBook_BookId1",
                table: "GenreBook");

            migrationBuilder.DropColumn(
                name: "BookId1",
                table: "GenreBook");

            migrationBuilder.DropColumn(
                name: "GenreName",
                table: "Books");
        }
    }
}
