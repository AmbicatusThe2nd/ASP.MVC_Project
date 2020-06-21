﻿// <auto-generated />
using System;
using Feniks_WebApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Feniks_WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Naloga2_Tkalcic.Models.Film", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dolzina")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("St_Izvodov")
                        .HasColumnType("int");

                    b.Property<string>("Zanr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("Naloga2_Tkalcic.Models.Izposoja", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<DateTime>("Datum_Do")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datum_Od")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilmID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FilmID1")
                        .HasColumnType("int");

                    b.Property<string>("UporabnikID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UporabnikIDUporabnik")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FilmID1");

                    b.HasIndex("UporabnikIDUporabnik");

                    b.ToTable("Izposoje");
                });

            modelBuilder.Entity("Naloga2_Tkalcic.Models.Uporabnik", b =>
                {
                    b.Property<int>("IDUporabnik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DatumRojstva")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Drzava")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMSO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPosta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KrajRojstva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Posta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostnaStevilka")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Priimek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Starost")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDUporabnik");

                    b.ToTable("Uporabnik");
                });

            modelBuilder.Entity("Naloga2_Tkalcic.Models.Izposoja", b =>
                {
                    b.HasOne("Naloga2_Tkalcic.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmID1");

                    b.HasOne("Naloga2_Tkalcic.Models.Uporabnik", "Uporabnik")
                        .WithMany()
                        .HasForeignKey("UporabnikIDUporabnik");
                });
#pragma warning restore 612, 618
        }
    }
}
