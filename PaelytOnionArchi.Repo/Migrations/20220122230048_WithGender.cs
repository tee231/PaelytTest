using Microsoft.EntityFrameworkCore.Migrations;

namespace PaelytOnionArchi.Repo.Migrations
{
    public partial class WithGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "Gender",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Gender",
                newName: "GenderId");
        }
    }
}
