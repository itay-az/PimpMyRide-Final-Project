using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class fixedParts1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CauseOfArrival_Ticket_TicketId",
                table: "CauseOfArrival");

            migrationBuilder.DropForeignKey(
                name: "FK_Labor_Ticket_TicketId",
                table: "Labor");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Labor_TicketId",
                table: "Labor");

            migrationBuilder.DropIndex(
                name: "IX_CauseOfArrival_TicketId",
                table: "CauseOfArrival");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Labor");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "CauseOfArrival");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Labor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "CauseOfArrival",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(type: "int", nullable: true),
                    partName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.id);
                    table.ForeignKey(
                        name: "FK_Part_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Labor_TicketId",
                table: "Labor",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_CauseOfArrival_TicketId",
                table: "CauseOfArrival",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Part_TicketId",
                table: "Part",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_CauseOfArrival_Ticket_TicketId",
                table: "CauseOfArrival",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Labor_Ticket_TicketId",
                table: "Labor",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id");
        }
    }
}
