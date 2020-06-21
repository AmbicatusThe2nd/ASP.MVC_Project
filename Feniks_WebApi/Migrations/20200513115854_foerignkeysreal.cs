using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Feniks_WebApi.Migrations
{
    public partial class foerignkeysreal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izposoje_Film_FilmID",
                table: "Izposoje");

            migrationBuilder.DropForeignKey(
                name: "FK_Izposoje_Uporabnik_UporabnikID",
                table: "Izposoje");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Uporabnik");

            migrationBuilder.DropIndex(
                name: "IX_Izposoje_FilmID",
                table: "Izposoje");

            migrationBuilder.DropIndex(
                name: "IX_Izposoje_UporabnikID",
                table: "Izposoje");

            migrationBuilder.AlterColumn<string>(
                name: "UporabnikID",
                table: "Izposoje",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FilmID",
                table: "Izposoje",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UporabnikID",
                table: "Izposoje",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FilmID",
                table: "Izposoje",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dolzina = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_Izvodov = table.Column<int>(type: "int", nullable: false),
                    Zanr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Uporabnik",
                columns: table => new
                {
                    IDUporabnik = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRojstva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Drzava = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMSO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KrajRojstva = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Posta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostnaStevilka = table.Column<int>(type: "int", nullable: false),
                    Priimek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Starost = table.Column<int>(type: "int", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "IX_Izposoje_UporabnikID",
                table: "Izposoje",
                column: "UporabnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Izposoje_Film_FilmID",
                table: "Izposoje",
                column: "FilmID",
                principalTable: "Film",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Izposoje_Uporabnik_UporabnikID",
                table: "Izposoje",
                column: "UporabnikID",
                principalTable: "Uporabnik",
                principalColumn: "IDUporabnik",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
