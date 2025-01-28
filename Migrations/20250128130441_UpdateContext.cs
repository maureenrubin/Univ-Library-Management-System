using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    public partial class UpdateContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowBook_Users_UserId",
                table: "BorrowBook");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "BorrowBook",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BooksEntityBookId",
                table: "BorrowBook",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserEntityUserId",
                table: "BorrowBook",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBook_BooksEntityBookId",
                table: "BorrowBook",
                column: "BooksEntityBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowBook_UserEntityUserId",
                table: "BorrowBook",
                column: "UserEntityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowBook_Books_BooksEntityBookId",
                table: "BorrowBook",
                column: "BooksEntityBookId",
                principalTable: "Books",
                principalColumn: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowBook_Users_UserEntityUserId",
                table: "BorrowBook",
                column: "UserEntityUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowBook_Users_UserId",
                table: "BorrowBook",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowBook_Books_BooksEntityBookId",
                table: "BorrowBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowBook_Users_UserEntityUserId",
                table: "BorrowBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowBook_Users_UserId",
                table: "BorrowBook");

            migrationBuilder.DropIndex(
                name: "IX_BorrowBook_BooksEntityBookId",
                table: "BorrowBook");

            migrationBuilder.DropIndex(
                name: "IX_BorrowBook_UserEntityUserId",
                table: "BorrowBook");

            migrationBuilder.DropColumn(
                name: "BooksEntityBookId",
                table: "BorrowBook");

            migrationBuilder.DropColumn(
                name: "UserEntityUserId",
                table: "BorrowBook");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "BorrowBook",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowBook_Users_UserId",
                table: "BorrowBook",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
