using Microsoft.EntityFrameworkCore.Migrations;

namespace Feniks_WebApi.Migrations
{
    public partial class foerignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izposoje_Uporabnik_ClanIDUporabnik",
                table: "Izposoje");

            migrationBuilder.DropIndex(
                name: "IX_Izposoje_ClanIDUporabnik",
                table: "Izposoje");

            migrationBuilder.DropColumn(
                name: "ClanIDUporabnik",
                table: "Izposoje");

            migrationBuilder.AddColumn<int>(
                name: "UporabnikID",
                table: "Izposoje",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Izposoje_UporabnikID",
                table: "Izposoje",
                column: "UporabnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Izposoje_Uporabnik_UporabnikID",
                table: "Izposoje",
                column: "UporabnikID",
                principalTable: "Uporabnik",
                principalColumn: "IDUporabnik",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izposoje_Uporabnik_UporabnikID",
                table: "Izposoje");

            migrationBuilder.DropIndex(
                name: "IX_Izposoje_UporabnikID",
                table: "Izposoje");

            migrationBuilder.DropColumn(
                name: "UporabnikID",
                table: "Izposoje");

            migrationBuilder.AddColumn<int>(
                name: "ClanIDUporabnik",
                table: "Izposoje",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Izposoje_ClanIDUporabnik",
                table: "Izposoje",
                column: "ClanIDUporabnik");

            migrationBuilder.AddForeignKey(
                name: "FK_Izposoje_Uporabnik_ClanIDUporabnik",
                table: "Izposoje",
                column: "ClanIDUporabnik",
                principalTable: "Uporabnik",
                principalColumn: "IDUporabnik",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
