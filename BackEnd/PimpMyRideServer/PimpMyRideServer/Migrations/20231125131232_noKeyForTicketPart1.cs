using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class noKeyForTicketPart1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TicketPart",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ticketId",
                table: "TicketPart",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketPart",
                table: "TicketPart",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TicketPart_ticketId",
                table: "TicketPart",
                column: "ticketId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketPart_Ticket_ticketId",
                table: "TicketPart",
                column: "ticketId",
                principalTable: "Ticket",
                principalColumn: "ticketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketPart_Ticket_ticketId",
                table: "TicketPart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketPart",
                table: "TicketPart");

            migrationBuilder.DropIndex(
                name: "IX_TicketPart_ticketId",
                table: "TicketPart");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TicketPart");

            migrationBuilder.DropColumn(
                name: "ticketId",
                table: "TicketPart");
        }
    }
}
