using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Feniks_WebApi.Migrations
{
    public partial class foreignkeysver3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UporabnikIDUporabnik",
                table: "Izposoje",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: false),
                    Zanr = table.Column<string>(nullable: false),
                    Dolzina = table.Column<int>(nullable: false),
                    St_Izvodov = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Uporabnik",
                columns: table => new
                {
                    IDUporabnik = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: false),
                    Priimek = table.Column<string>(nullable: false),
                    DatumRojstva = table.Column<DateTime>(nullable: false),
                    EMSO = table.Column<string>(nullable: false),
                    Starost = table.Column<int>(nullable: false),
                    KrajRojstva = table.Column<string>(nullable: false),
                    Naslov = table.Column<string>(nullable: false),
                    PostnaStevilka = table.Column<int>(nullable: false),
                    Posta = table.Column<string>(nullable: false),
                    Drzava = table.Column<string>(nullable: false),
                    EPosta = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uporabnik", x => x.IDUporabnik);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Izposoje_FilmID",
                table: "Izposoje",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Izposoje_UporabnikIDUporabnik",
                table: "Izposoje",
                column: "UporabnikIDUporabnik");

            migrationBuilder.AddForeignKey(
                name: "FK_Izposoje_Film_FilmID",
                table: "Izposoje",
                column: "FilmID",
                principalTable: "Film",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Izposoje_Uporabnik_UporabnikIDUporabnik",
                table: "Izposoje",
                column: "UporabnikIDUporabnik",
                principalTable: "Uporabnik",
                principalColumn: "IDUporabnik",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izposoje_Film_FilmID",
                table: "Izposoje");

            migrationBuilder.DropForeignKey(
                name: "FK_Izposoje_Uporabnik_UporabnikIDUporabnik",
                table: "Izposoje");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Uporabnik");

            migrationBuilder.DropIndex(
                name: "IX_Izposoje_FilmID",
                table: "Izposoje");

            migrationBuilder.DropIndex(
                name: "IX_Izposoje_UporabnikIDUporabnik",
                table: "Izposoje");

            migrationBuilder.DropColumn(
                name: "UporabnikIDUporabnik",
                table: "Izposoje");
        }
    }
}
