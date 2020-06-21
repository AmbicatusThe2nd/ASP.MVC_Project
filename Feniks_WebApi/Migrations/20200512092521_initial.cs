using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Feniks_WebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Izposoje",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum_Od = table.Column<DateTime>(nullable: false),
                    Datum_Do = table.Column<DateTime>(nullable: false),
                    Cena = table.Column<double>(nullable: false),
                    ClanIDUporabnik = table.Column<int>(nullable: true),
                    FilmID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izposoje", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Izposoje_Uporabnik_ClanIDUporabnik",
                        column: x => x.ClanIDUporabnik,
                        principalTable: "Uporabnik",
                        principalColumn: "IDUporabnik",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Izposoje_Film_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Film",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Izposoje_ClanIDUporabnik",
                table: "Izposoje",
                column: "ClanIDUporabnik");

            migrationBuilder.CreateIndex(
                name: "IX_Izposoje_FilmID",
                table: "Izposoje",
                column: "FilmID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Izposoje");

            migrationBuilder.DropTable(
                name: "Uporabnik");

            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
