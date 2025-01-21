using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    public partial class FixFKDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarrowBook_Books_BookId",
                table: "BarrowBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BarrowBook_Users_UserId",
                table: "BarrowBook");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategory_CategoryId",
                table: "Books");

            migrationBuilder.AlterColumn<byte[]>(
                name: "AdminPicture",
                table: "Admins",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_BarrowBook_Books_BookId",
                table: "BarrowBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BarrowBook_Users_UserId",
                table: "BarrowBook",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategory_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "BookCategory",
                principalColumn: "BCategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarrowBook_Books_BookId",
                table: "BarrowBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BarrowBook_Users_UserId",
                table: "BarrowBook");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategory_CategoryId",
                table: "Books");

            migrationBuilder.AlterColumn<byte[]>(
                name: "AdminPicture",
                table: "Admins",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BarrowBook_Books_BookId",
                table: "BarrowBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BarrowBook_Users_UserId",
                table: "BarrowBook",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategory_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "BookCategory",
                principalColumn: "BCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
