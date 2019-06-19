﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SeekAndFind.Migrations
{
    public partial class nasljedjivanje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FakultetiAplikanta_Korisnik_AplikantId",
                table: "FakultetiAplikanta");

            migrationBuilder.DropForeignKey(
                name: "FK_JeziciAplikanta_Korisnik_AplikantId",
                table: "JeziciAplikanta");

            migrationBuilder.DropForeignKey(
                name: "FK_Obavijest_Korisnik_AplikantId",
                table: "Obavijest");

            migrationBuilder.DropForeignKey(
                name: "FK_RadnoIskustvoAplikanta_Korisnik_AplikantId",
                table: "RadnoIskustvoAplikanta");

            migrationBuilder.DropForeignKey(
                name: "FK_RegistrovaniAplikanti_Korisnik_AplikantId",
                table: "RegistrovaniAplikanti");

            migrationBuilder.DropForeignKey(
                name: "FK_SrednjaSkolaAplikanta_Korisnik_AplikantId",
                table: "SrednjaSkolaAplikanta");

            migrationBuilder.DropColumn(
                name: "AplikantId",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "PoslodavacId",
                table: "Korisnik");

            migrationBuilder.RenameColumn(
                name: "AplikantId",
                table: "SrednjaSkolaAplikanta",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_SrednjaSkolaAplikanta_AplikantId",
                table: "SrednjaSkolaAplikanta",
                newName: "IX_SrednjaSkolaAplikanta_KorisnikId");

            migrationBuilder.RenameColumn(
                name: "AplikantId",
                table: "RegistrovaniAplikanti",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_RegistrovaniAplikanti_AplikantId",
                table: "RegistrovaniAplikanti",
                newName: "IX_RegistrovaniAplikanti_KorisnikId");

            migrationBuilder.RenameColumn(
                name: "AplikantId",
                table: "RadnoIskustvoAplikanta",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_RadnoIskustvoAplikanta_AplikantId",
                table: "RadnoIskustvoAplikanta",
                newName: "IX_RadnoIskustvoAplikanta_KorisnikId");

            migrationBuilder.RenameColumn(
                name: "AplikantId",
                table: "Obavijest",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Obavijest_AplikantId",
                table: "Obavijest",
                newName: "IX_Obavijest_KorisnikId");

            migrationBuilder.RenameColumn(
                name: "AplikantId",
                table: "JeziciAplikanta",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_JeziciAplikanta_AplikantId",
                table: "JeziciAplikanta",
                newName: "IX_JeziciAplikanta_KorisnikId");

            migrationBuilder.RenameColumn(
                name: "AplikantId",
                table: "FakultetiAplikanta",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_FakultetiAplikanta_AplikantId",
                table: "FakultetiAplikanta",
                newName: "IX_FakultetiAplikanta_KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_FakultetiAplikanta_Korisnik_KorisnikId",
                table: "FakultetiAplikanta",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JeziciAplikanta_Korisnik_KorisnikId",
                table: "JeziciAplikanta",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijest_Korisnik_KorisnikId",
                table: "Obavijest",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RadnoIskustvoAplikanta_Korisnik_KorisnikId",
                table: "RadnoIskustvoAplikanta",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistrovaniAplikanti_Korisnik_KorisnikId",
                table: "RegistrovaniAplikanti",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SrednjaSkolaAplikanta_Korisnik_KorisnikId",
                table: "SrednjaSkolaAplikanta",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FakultetiAplikanta_Korisnik_KorisnikId",
                table: "FakultetiAplikanta");

            migrationBuilder.DropForeignKey(
                name: "FK_JeziciAplikanta_Korisnik_KorisnikId",
                table: "JeziciAplikanta");

            migrationBuilder.DropForeignKey(
                name: "FK_Obavijest_Korisnik_KorisnikId",
                table: "Obavijest");

            migrationBuilder.DropForeignKey(
                name: "FK_RadnoIskustvoAplikanta_Korisnik_KorisnikId",
                table: "RadnoIskustvoAplikanta");

            migrationBuilder.DropForeignKey(
                name: "FK_RegistrovaniAplikanti_Korisnik_KorisnikId",
                table: "RegistrovaniAplikanti");

            migrationBuilder.DropForeignKey(
                name: "FK_SrednjaSkolaAplikanta_Korisnik_KorisnikId",
                table: "SrednjaSkolaAplikanta");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "SrednjaSkolaAplikanta",
                newName: "AplikantId");

            migrationBuilder.RenameIndex(
                name: "IX_SrednjaSkolaAplikanta_KorisnikId",
                table: "SrednjaSkolaAplikanta",
                newName: "IX_SrednjaSkolaAplikanta_AplikantId");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "RegistrovaniAplikanti",
                newName: "AplikantId");

            migrationBuilder.RenameIndex(
                name: "IX_RegistrovaniAplikanti_KorisnikId",
                table: "RegistrovaniAplikanti",
                newName: "IX_RegistrovaniAplikanti_AplikantId");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "RadnoIskustvoAplikanta",
                newName: "AplikantId");

            migrationBuilder.RenameIndex(
                name: "IX_RadnoIskustvoAplikanta_KorisnikId",
                table: "RadnoIskustvoAplikanta",
                newName: "IX_RadnoIskustvoAplikanta_AplikantId");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "Obavijest",
                newName: "AplikantId");

            migrationBuilder.RenameIndex(
                name: "IX_Obavijest_KorisnikId",
                table: "Obavijest",
                newName: "IX_Obavijest_AplikantId");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "JeziciAplikanta",
                newName: "AplikantId");

            migrationBuilder.RenameIndex(
                name: "IX_JeziciAplikanta_KorisnikId",
                table: "JeziciAplikanta",
                newName: "IX_JeziciAplikanta_AplikantId");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "FakultetiAplikanta",
                newName: "AplikantId");

            migrationBuilder.RenameIndex(
                name: "IX_FakultetiAplikanta_KorisnikId",
                table: "FakultetiAplikanta",
                newName: "IX_FakultetiAplikanta_AplikantId");

            migrationBuilder.AddColumn<int>(
                name: "AplikantId",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PoslodavacId",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FakultetiAplikanta_Korisnik_AplikantId",
                table: "FakultetiAplikanta",
                column: "AplikantId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JeziciAplikanta_Korisnik_AplikantId",
                table: "JeziciAplikanta",
                column: "AplikantId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijest_Korisnik_AplikantId",
                table: "Obavijest",
                column: "AplikantId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RadnoIskustvoAplikanta_Korisnik_AplikantId",
                table: "RadnoIskustvoAplikanta",
                column: "AplikantId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistrovaniAplikanti_Korisnik_AplikantId",
                table: "RegistrovaniAplikanti",
                column: "AplikantId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SrednjaSkolaAplikanta_Korisnik_AplikantId",
                table: "SrednjaSkolaAplikanta",
                column: "AplikantId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
