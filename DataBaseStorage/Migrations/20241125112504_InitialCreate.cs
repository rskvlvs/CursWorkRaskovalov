using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseStorage.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dm1 = table.Column<double>(type: "float", nullable: false),
                    delta_h = table.Column<double>(type: "float", nullable: false),
                    Vm = table.Column<double>(type: "float", nullable: false),
                    sigmastr = table.Column<double>(type: "float", nullable: false),
                    u = table.Column<double>(type: "float", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Khl = table.Column<double>(type: "float", nullable: false),
                    Ze = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "units",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kh = table.Column<double>(type: "float", nullable: false),
                    Kha = table.Column<double>(type: "float", nullable: false),
                    Khv = table.Column<double>(type: "float", nullable: false),
                    Khb = table.Column<double>(type: "float", nullable: false),
                    OmegaHT = table.Column<double>(type: "float", nullable: false),
                    OmegaHV = table.Column<double>(type: "float", nullable: false),
                    g0 = table.Column<double>(type: "float", nullable: false),
                    sigmaH = table.Column<double>(type: "float", nullable: false),
                    sigmaHP = table.Column<double>(type: "float", nullable: false),
                    Zh = table.Column<double>(type: "float", nullable: false),
                    Zm = table.Column<double>(type: "float", nullable: false),
                    Ft = table.Column<double>(type: "float", nullable: false),
                    b = table.Column<double>(type: "float", nullable: false),
                    Ea = table.Column<double>(type: "float", nullable: false),
                    Re = table.Column<double>(type: "float", nullable: false),
                    def_sigmaH_sigmaHP = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "resultEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    detailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    unitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sigmaH = table.Column<double>(type: "float", nullable: false),
                    sigmaHP = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resultEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_resultEntities_details_detailId",
                        column: x => x.detailId,
                        principalTable: "details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resultEntities_units_unitId",
                        column: x => x.unitId,
                        principalTable: "units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resultEntities_detailId",
                table: "resultEntities",
                column: "detailId");

            migrationBuilder.CreateIndex(
                name: "IX_resultEntities_unitId",
                table: "resultEntities",
                column: "unitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "resultEntities");

            migrationBuilder.DropTable(
                name: "details");

            migrationBuilder.DropTable(
                name: "units");
        }
    }
}
