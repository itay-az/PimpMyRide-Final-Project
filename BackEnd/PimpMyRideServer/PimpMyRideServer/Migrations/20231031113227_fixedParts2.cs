using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class fixedParts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ticketId",
                table: "Labor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ticketId",
                table: "CauseOfArrival",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    partId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    partName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ticketId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.partId);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    ticketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    partId = table.Column<int>(type: "int", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.ticketId);
                });

            migrationBuilder.CreateTable(
                name: "PartTicket",
                columns: table => new
                {
                    partspartId = table.Column<int>(type: "int", nullable: false),
                    ticketsticketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTicket", x => new { x.partspartId, x.ticketsticketId });
                    table.ForeignKey(
                        name: "FK_PartTicket_Part_partspartId",
                        column: x => x.partspartId,
                        principalTable: "Part",
                        principalColumn: "partId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartTicket_Ticket_ticketsticketId",
                        column: x => x.ticketsticketId,
                        principalTable: "Ticket",
                        principalColumn: "ticketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Labor_ticketId",
                table: "Labor",
                column: "ticketId");

            migrationBuilder.CreateIndex(
                name: "IX_CauseOfArrival_ticketId",
                table: "CauseOfArrival",
                column: "ticketId");

            migrationBuilder.CreateIndex(
                name: "IX_PartTicket_ticketsticketId",
                table: "PartTicket",
                column: "ticketsticketId");

            migrationBuilder.AddForeignKey(
                name: "FK_CauseOfArrival_Ticket_ticketId",
                table: "CauseOfArrival",
                column: "ticketId",
                principalTable: "Ticket",
                principalColumn: "ticketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Labor_Ticket_ticketId",
                table: "Labor",
                column: "ticketId",
                principalTable: "Ticket",
                principalColumn: "ticketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CauseOfArrival_Ticket_ticketId",
                table: "CauseOfArrival");

            migrationBuilder.DropForeignKey(
                name: "FK_Labor_Ticket_ticketId",
                table: "Labor");

            migrationBuilder.DropTable(
                name: "PartTicket");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Labor_ticketId",
                table: "Labor");

            migrationBuilder.DropIndex(
                name: "IX_CauseOfArrival_ticketId",
                table: "CauseOfArrival");

            migrationBuilder.DropColumn(
                name: "ticketId",
                table: "Labor");

            migrationBuilder.DropColumn(
                name: "ticketId",
                table: "CauseOfArrival");
        }
    }
}
