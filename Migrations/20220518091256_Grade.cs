using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EloctrnicJournal_EF.Migrations
{
    public partial class Grade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Rating",
                newName: "Grades");

            migrationBuilder.RenameColumn(
                name: "StudenId",
                table: "Passes",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "DatePass",
                table: "Passes",
                newName: "DateRating");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Passes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Passes");

            migrationBuilder.RenameColumn(
                name: "Grades",
                table: "Rating",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Passes",
                newName: "StudenId");

            migrationBuilder.RenameColumn(
                name: "DateRating",
                table: "Passes",
                newName: "DatePass");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
