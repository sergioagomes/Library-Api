using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class teste1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Author_AuthorName",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Books",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorName",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Author_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Author_AuthorId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Books",
                newName: "AuthorName");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                newName: "IX_Books_AuthorName");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Author_AuthorName",
                table: "Books",
                column: "AuthorName",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
