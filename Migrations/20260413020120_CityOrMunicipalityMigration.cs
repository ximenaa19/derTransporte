using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace derTransporte.Migrations
{
    /// <inheritdoc />
    public partial class CityOrMunicipalityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cityOrMunicipality",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stateRegId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Coordinates = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StateOrRegionsEntityId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cityOrMunicipality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cityOrMunicipality_StateOrRegions_StateOrRegionsEntityId",
                        column: x => x.StateOrRegionsEntityId,
                        principalTable: "StateOrRegions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_cityOrMunicipality_StateOrRegions_stateRegId",
                        column: x => x.stateRegId,
                        principalTable: "StateOrRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_cityOrMunicipality_Code",
                table: "cityOrMunicipality",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cityOrMunicipality_StateOrRegionsEntityId",
                table: "cityOrMunicipality",
                column: "StateOrRegionsEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_cityOrMunicipality_stateRegId",
                table: "cityOrMunicipality",
                column: "stateRegId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cityOrMunicipality");
        }
    }
}
