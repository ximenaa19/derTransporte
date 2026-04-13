using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace derTransporte.Migrations
{
    /// <inheritdoc />
    public partial class LoadsAndBidsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    OriginAddress = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinationAddress = table.Column<string>(type: "TEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OriginCoords = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinationCoords = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WeightTons = table.Column<decimal>(type: "DECIMAL(65,30)", nullable: false),
                    VolumeM3 = table.Column<decimal>(type: "DECIMAL(65,30)", nullable: false),
                    PickupDate = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    OfferedPrice = table.Column<decimal>(type: "DECIMAL(65,30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    CustomerId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TypeLoadId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    OriginCityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DestinationCityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StatusId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_loads_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_loads_destination_city",
                        column: x => x.DestinationCityId,
                        principalTable: "cityOrMunicipality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_loads_origin_city",
                        column: x => x.OriginCityId,
                        principalTable: "cityOrMunicipality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bids",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<decimal>(type: "DECIMAL(65,30)", nullable: false),
                    EtaToPickup = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    LoadId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DriverId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    VehicleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StatusBidsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bids_drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bids_loads_LoadId",
                        column: x => x.LoadId,
                        principalTable: "loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bids_vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_bids_DriverId",
                table: "bids",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_bids_LoadId",
                table: "bids",
                column: "LoadId");

            migrationBuilder.CreateIndex(
                name: "IX_bids_VehicleId",
                table: "bids",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_loads_CustomerId",
                table: "loads",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_loads_DestinationCityId",
                table: "loads",
                column: "DestinationCityId");

            migrationBuilder.CreateIndex(
                name: "IX_loads_OriginCityId",
                table: "loads",
                column: "OriginCityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bids");

            migrationBuilder.DropTable(
                name: "loads");
        }
    }
}
