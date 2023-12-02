using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class Fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksSessions_Books_BookId",
                table: "BooksSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksSessions_Libraries_LibrariesId",
                table: "BooksSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksSessions",
                table: "BooksSessions");

            migrationBuilder.RenameTable(
                name: "BooksSessions",
                newName: "LibraryBook");

            migrationBuilder.RenameIndex(
                name: "IX_BooksSessions_LibrariesId",
                table: "LibraryBook",
                newName: "IX_LibraryBook_LibrariesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryBook",
                table: "LibraryBook",
                columns: new[] { "BookId", "LibrariesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryBook_Books_BookId",
                table: "LibraryBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryBook_Libraries_LibrariesId",
                table: "LibraryBook",
                column: "LibrariesId",
                principalTable: "Libraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryBook_Books_BookId",
                table: "LibraryBook");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryBook_Libraries_LibrariesId",
                table: "LibraryBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryBook",
                table: "LibraryBook");

            migrationBuilder.RenameTable(
                name: "LibraryBook",
                newName: "BooksSessions");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryBook_LibrariesId",
                table: "BooksSessions",
                newName: "IX_BooksSessions_LibrariesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksSessions",
                table: "BooksSessions",
                columns: new[] { "BookId", "LibrariesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BooksSessions_Books_BookId",
                table: "BooksSessions",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksSessions_Libraries_LibrariesId",
                table: "BooksSessions",
                column: "LibrariesId",
                principalTable: "Libraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
