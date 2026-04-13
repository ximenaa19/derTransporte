using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace derTransporte.Migrations
{
    /// <inheritdoc />
    public partial class CityOrMunicipality2Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cityOrMunicipality_StateOrRegions_StateOrRegionsEntityId",
                table: "cityOrMunicipality");

            migrationBuilder.DropIndex(
                name: "IX_cityOrMunicipality_StateOrRegionsEntityId",
                table: "cityOrMunicipality");

            migrationBuilder.DropColumn(
                name: "StateOrRegionsEntityId",
                table: "cityOrMunicipality");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StateOrRegionsEntityId",
                table: "cityOrMunicipality",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_cityOrMunicipality_StateOrRegionsEntityId",
                table: "cityOrMunicipality",
                column: "StateOrRegionsEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_cityOrMunicipality_StateOrRegions_StateOrRegionsEntityId",
                table: "cityOrMunicipality",
                column: "StateOrRegionsEntityId",
                principalTable: "StateOrRegions",
                principalColumn: "Id");
        }
    }
}
