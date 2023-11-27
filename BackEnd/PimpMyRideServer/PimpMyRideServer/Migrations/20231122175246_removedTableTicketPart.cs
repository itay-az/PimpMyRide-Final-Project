using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class removedTableTicketPart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketPart_Part_partspartId",
                table: "TicketPart");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketPart_Ticket_ticketsticketId",
                table: "TicketPart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketPart",
                table: "TicketPart");

            migrationBuilder.RenameTable(
                name: "TicketPart",
                newName: "PartTicket");

            migrationBuilder.RenameIndex(
                name: "IX_TicketPart_ticketsticketId",
                table: "PartTicket",
                newName: "IX_PartTicket_ticketsticketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartTicket",
                table: "PartTicket",
                columns: new[] { "partspartId", "ticketsticketId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PartTicket_Part_partspartId",
                table: "PartTicket",
                column: "partspartId",
                principalTable: "Part",
                principalColumn: "partId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartTicket_Ticket_ticketsticketId",
                table: "PartTicket",
                column: "ticketsticketId",
                principalTable: "Ticket",
                principalColumn: "ticketId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartTicket_Part_partspartId",
                table: "PartTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_PartTicket_Ticket_ticketsticketId",
                table: "PartTicket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartTicket",
                table: "PartTicket");

            migrationBuilder.RenameTable(
                name: "PartTicket",
                newName: "TicketPart");

            migrationBuilder.RenameIndex(
                name: "IX_PartTicket_ticketsticketId",
                table: "TicketPart",
                newName: "IX_TicketPart_ticketsticketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketPart",
                table: "TicketPart",
                columns: new[] { "partspartId", "ticketsticketId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TicketPart_Part_partspartId",
                table: "TicketPart",
                column: "partspartId",
                principalTable: "Part",
                principalColumn: "partId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketPart_Ticket_ticketsticketId",
                table: "TicketPart",
                column: "ticketsticketId",
                principalTable: "Ticket",
                principalColumn: "ticketId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
