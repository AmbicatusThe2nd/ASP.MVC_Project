using Microsoft.EntityFrameworkCore.Migrations;

namespace Naloga2_Tkalcic.Migrations
{
    public partial class foreignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izpsoje_Clan_ClanID",
                table: "Izpsoje");

            migrationBuilder.DropForeignKey(
                name: "FK_Izpsoje_Filmi_FilmID",
                table: "Izpsoje");

            migrationBuilder.DropTable(
                name: "Clan");

            migrationBuilder.DropIndex(
                name: "IX_Izpsoje_ClanID",
                table: "Izpsoje");

            migrationBuilder.DropColumn(
                name: "ClanID",
                table: "Izpsoje");

            migrationBuilder.AlterColumn<int>(
                name: "FilmID",
                table: "Izpsoje",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UporabnikID",
                table: "Izpsoje",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Izpsoje_UporabnikID",
                table: "Izpsoje",
                column: "UporabnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Izpsoje_Filmi_FilmID",
                table: "Izpsoje",
                column: "FilmID",
                principalTable: "Filmi",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Izpsoje_AspNetUsers_UporabnikID",
                table: "Izpsoje",
                column: "UporabnikID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izpsoje_Filmi_FilmID",
                table: "Izpsoje");

            migrationBuilder.DropForeignKey(
                name: "FK_Izpsoje_AspNetUsers_UporabnikID",
                table: "Izpsoje");

            migrationBuilder.DropIndex(
                name: "IX_Izpsoje_UporabnikID",
                table: "Izpsoje");

            migrationBuilder.DropColumn(
                name: "UporabnikID",
                table: "Izpsoje");

            migrationBuilder.AlterColumn<int>(
                name: "FilmID",
                table: "Izpsoje",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ClanID",
                table: "Izpsoje",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clanarina = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priimek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Starost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clan", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Izpsoje_ClanID",
                table: "Izpsoje",
                column: "ClanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Izpsoje_Clan_ClanID",
                table: "Izpsoje",
                column: "ClanID",
                principalTable: "Clan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Izpsoje_Filmi_FilmID",
                table: "Izpsoje",
                column: "FilmID",
                principalTable: "Filmi",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
