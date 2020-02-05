using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyAqq.WebApp.Migrations
{
    public partial class UpdateAuthorToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Author",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
