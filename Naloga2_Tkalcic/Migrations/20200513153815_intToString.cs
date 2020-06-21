using Microsoft.EntityFrameworkCore.Migrations;

namespace Naloga2_Tkalcic.Migrations
{
    public partial class intToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izpsoje_Filmi_FilmID",
                table: "Izpsoje");

            migrationBuilder.DropIndex(
                name: "IX_Izpsoje_FilmID",
                table: "Izpsoje");

            migrationBuilder.AlterColumn<string>(
                name: "FilmID",
                table: "Izpsoje",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FilmID1",
                table: "Izpsoje",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Izpsoje_FilmID1",
                table: "Izpsoje",
                column: "FilmID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Izpsoje_Filmi_FilmID1",
                table: "Izpsoje",
                column: "FilmID1",
                principalTable: "Filmi",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izpsoje_Filmi_FilmID1",
                table: "Izpsoje");

            migrationBuilder.DropIndex(
                name: "IX_Izpsoje_FilmID1",
                table: "Izpsoje");

            migrationBuilder.DropColumn(
                name: "FilmID1",
                table: "Izpsoje");

            migrationBuilder.AlterColumn<int>(
                name: "FilmID",
                table: "Izpsoje",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Izpsoje_FilmID",
                table: "Izpsoje",
                column: "FilmID");

            migrationBuilder.AddForeignKey(
                name: "FK_Izpsoje_Filmi_FilmID",
                table: "Izpsoje",
                column: "FilmID",
                principalTable: "Filmi",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
