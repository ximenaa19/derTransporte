using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace derTransporte.Migrations
{
    /// <inheritdoc />
    public partial class TransportCompaniesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transport_companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nit = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailCorp = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactName = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactEmail = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPhone = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogoUrl = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VerifiedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    CityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StatusId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LegalRepresentativeId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transport_companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transport_companies_cityOrMunicipality_CityId",
                        column: x => x.CityId,
                        principalTable: "cityOrMunicipality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transport_companies_persons_LegalRepresentativeId",
                        column: x => x.LegalRepresentativeId,
                        principalTable: "persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_transport_companies_CityId",
                table: "transport_companies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_transport_companies_ContactEmail",
                table: "transport_companies",
                column: "ContactEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_transport_companies_EmailCorp",
                table: "transport_companies",
                column: "EmailCorp",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_transport_companies_LegalRepresentativeId",
                table: "transport_companies",
                column: "LegalRepresentativeId");

            migrationBuilder.CreateIndex(
                name: "IX_transport_companies_Nit",
                table: "transport_companies",
                column: "Nit",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transport_companies");
        }
    }
}
