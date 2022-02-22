using Microsoft.EntityFrameworkCore.Migrations;

namespace PaelytOnionArchi.Repo.Migrations
{
    public partial class news : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Customer_Id",
                table: "Photos");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Photos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_CustomerId",
                table: "Photos",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Customer_CustomerId",
                table: "Photos",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Customer_CustomerId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_CustomerId",
                table: "Photos");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Photos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Customer_Id",
                table: "Photos",
                column: "Id",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
