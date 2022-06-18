using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tests22297.Migrations
{
    /// <inheritdoc />
    public partial class initMigr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    IdAction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NeedSpecialEquipment = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.IdAction);
                });

            migrationBuilder.CreateTable(
                name: "FireFighters",
                columns: table => new
                {
                    IdFireFighter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireFighters", x => x.IdFireFighter);
                });

            migrationBuilder.CreateTable(
                name: "FireTrucks",
                columns: table => new
                {
                    IdFireTruck = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationalNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SpecialEquipment = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireTrucks", x => x.IdFireTruck);
                });

            migrationBuilder.CreateTable(
                name: "FireFightersActions",
                columns: table => new
                {
                    IdFireFighterAction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFireFighter = table.Column<int>(type: "int", nullable: false),
                    IdAction = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireFightersActions", x => x.IdFireFighterAction);
                    table.ForeignKey(
                        name: "FK_FireFightersActions_Actions_IdAction",
                        column: x => x.IdAction,
                        principalTable: "Actions",
                        principalColumn: "IdAction",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FireFightersActions_FireFighters_IdFireFighter",
                        column: x => x.IdFireFighter,
                        principalTable: "FireFighters",
                        principalColumn: "IdFireFighter",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireTruckActions",
                columns: table => new
                {
                    IdFireTruckAction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFireTruck = table.Column<int>(type: "int", nullable: false),
                    IdAction = table.Column<int>(type: "int", nullable: false),
                    AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireTruckActions", x => x.IdFireTruckAction);
                    table.ForeignKey(
                        name: "FK_FireTruckActions_Actions_IdAction",
                        column: x => x.IdAction,
                        principalTable: "Actions",
                        principalColumn: "IdAction",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FireTruckActions_FireTrucks_IdFireTruck",
                        column: x => x.IdFireTruck,
                        principalTable: "FireTrucks",
                        principalColumn: "IdFireTruck",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FireFightersActions_IdAction",
                table: "FireFightersActions",
                column: "IdAction");

            migrationBuilder.CreateIndex(
                name: "IX_FireFightersActions_IdFireFighter",
                table: "FireFightersActions",
                column: "IdFireFighter");

            migrationBuilder.CreateIndex(
                name: "IX_FireTruckActions_IdAction",
                table: "FireTruckActions",
                column: "IdAction");

            migrationBuilder.CreateIndex(
                name: "IX_FireTruckActions_IdFireTruck",
                table: "FireTruckActions",
                column: "IdFireTruck");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FireFightersActions");

            migrationBuilder.DropTable(
                name: "FireTruckActions");

            migrationBuilder.DropTable(
                name: "FireFighters");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "FireTrucks");
        }
    }
}
