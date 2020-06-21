using Microsoft.EntityFrameworkCore.Migrations;

namespace Feniks_WebApi.Migrations
{
    public partial class intToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izposoje_Film_FilmID",
                table: "Izposoje");

            migrationBuilder.DropIndex(
                name: "IX_Izposoje_FilmID",
                table: "Izposoje");

            migrationBuilder.AlterColumn<string>(
                name: "FilmID",
                table: "Izposoje",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FilmID1",
                table: "Izposoje",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Izposoje_FilmID1",
                table: "Izposoje",
                column: "FilmID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Izposoje_Film_FilmID1",
                table: "Izposoje",
                column: "FilmID1",
                principalTable: "Film",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izposoje_Film_FilmID1",
                table: "Izposoje");

            migrationBuilder.DropIndex(
                name: "IX_Izposoje_FilmID1",
                table: "Izposoje");

            migrationBuilder.DropColumn(
                name: "FilmID1",
                table: "Izposoje");

            migrationBuilder.AlterColumn<int>(
                name: "FilmID",
                table: "Izposoje",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Izposoje_FilmID",
                table: "Izposoje",
                column: "FilmID");

            migrationBuilder.AddForeignKey(
                name: "FK_Izposoje_Film_FilmID",
                table: "Izposoje",
                column: "FilmID",
                principalTable: "Film",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
