using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace derTransporte.Migrations
{
    /// <inheritdoc />
    public partial class TripsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "trips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FinalPrice = table.Column<decimal>(type: "DECIMAL(65,30)", nullable: false),
                    ManifestNumber = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrackingToken = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartTime = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    EndTime = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    LoadId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DriverId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trips_bids_BidId",
                        column: x => x.BidId,
                        principalTable: "bids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trips_drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trips_loads_LoadId",
                        column: x => x.LoadId,
                        principalTable: "loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_trips_BidId",
                table: "trips",
                column: "BidId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_trips_DriverId",
                table: "trips",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_trips_LoadId",
                table: "trips",
                column: "LoadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trips");
        }
    }
}
