using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace derTransporte.Migrations
{
    /// <inheritdoc />
    public partial class CityRulesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "city_pricing_rules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BaseCreditPrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    CityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city_pricing_rules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_city_pricing_rules_cityOrMunicipality_CityId",
                        column: x => x.CityId,
                        principalTable: "cityOrMunicipality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_city_pricing_rules_CityId",
                table: "city_pricing_rules",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "city_pricing_rules");
        }
    }
}
