using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace derTransporte.Migrations
{
    /// <inheritdoc />
    public partial class LoadsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "load_details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RequiresPackaging = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    IsFragile = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    IsStackable = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    RequiredInsurance = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    SpecialInstructions = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Metadata = table.Column<string>(type: "JSON", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoadId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_load_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_load_details_loads_LoadId",
                        column: x => x.LoadId,
                        principalTable: "loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "load_images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoadId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_load_images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_load_images_loads_LoadId",
                        column: x => x.LoadId,
                        principalTable: "loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "load_status_history",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StatusName = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Notes = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    LoadId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ChangedById = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_load_status_history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_load_status_history_loads_LoadId",
                        column: x => x.LoadId,
                        principalTable: "loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_load_status_history_persons_ChangedById",
                        column: x => x.ChangedById,
                        principalTable: "persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "price_history",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MinPrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    MaxPrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    AveragePrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    SicetacReferencePrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    ReferenceDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    OriginCityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DestinationCityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TypeVehicleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TypeLoadId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_price_history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_price_history_destination_city",
                        column: x => x.DestinationCityId,
                        principalTable: "cityOrMunicipality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_price_history_origin_city",
                        column: x => x.OriginCityId,
                        principalTable: "cityOrMunicipality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "return_load_suggestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Score = table.Column<decimal>(type: "DECIMAL(5,2)", nullable: false),
                    DriverId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CurrentLoadId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SuggestedLoadId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_return_load_suggestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_return_load_suggestions_drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_return_suggestions_current_load",
                        column: x => x.CurrentLoadId,
                        principalTable: "loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_return_suggestions_suggested_load",
                        column: x => x.SuggestedLoadId,
                        principalTable: "loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_load_details_LoadId",
                table: "load_details",
                column: "LoadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_load_images_LoadId",
                table: "load_images",
                column: "LoadId");

            migrationBuilder.CreateIndex(
                name: "IX_load_status_history_ChangedById",
                table: "load_status_history",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_load_status_history_LoadId",
                table: "load_status_history",
                column: "LoadId");

            migrationBuilder.CreateIndex(
                name: "IX_price_history_DestinationCityId",
                table: "price_history",
                column: "DestinationCityId");

            migrationBuilder.CreateIndex(
                name: "IX_price_history_OriginCityId",
                table: "price_history",
                column: "OriginCityId");

            migrationBuilder.CreateIndex(
                name: "IX_return_load_suggestions_CurrentLoadId",
                table: "return_load_suggestions",
                column: "CurrentLoadId");

            migrationBuilder.CreateIndex(
                name: "IX_return_load_suggestions_DriverId",
                table: "return_load_suggestions",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_return_load_suggestions_SuggestedLoadId",
                table: "return_load_suggestions",
                column: "SuggestedLoadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "load_details");

            migrationBuilder.DropTable(
                name: "load_images");

            migrationBuilder.DropTable(
                name: "load_status_history");

            migrationBuilder.DropTable(
                name: "price_history");

            migrationBuilder.DropTable(
                name: "return_load_suggestions");
        }
    }
}
