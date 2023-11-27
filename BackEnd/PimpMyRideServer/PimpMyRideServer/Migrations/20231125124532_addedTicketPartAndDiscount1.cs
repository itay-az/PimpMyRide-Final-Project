using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class addedTicketPartAndDiscount1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartTicketJoin");

            migrationBuilder.AddColumn<int>(
                name: "ticketId",
                table: "TicketPart",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "partId",
                table: "Ticket",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TicketPart_ticketId",
                table: "TicketPart",
                column: "ticketId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_partId",
                table: "Ticket",
                column: "partId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Part_partId",
                table: "Ticket",
                column: "partId",
                principalTable: "Part",
                principalColumn: "partId");

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
                name: "FK_Ticket_Part_partId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketPart_Ticket_ticketId",
                table: "TicketPart");

            migrationBuilder.DropIndex(
                name: "IX_TicketPart_ticketId",
                table: "TicketPart");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_partId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ticketId",
                table: "TicketPart");

            migrationBuilder.DropColumn(
                name: "partId",
                table: "Ticket");

            migrationBuilder.CreateTable(
                name: "PartTicketJoin",
                columns: table => new
                {
                    partId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ticketId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTicketJoin", x => new { x.partId, x.ticketId });
                    table.ForeignKey(
                        name: "FK_PartTicketJoin_Part_partId",
                        column: x => x.partId,
                        principalTable: "Part",
                        principalColumn: "partId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartTicketJoin_Ticket_ticketId",
                        column: x => x.ticketId,
                        principalTable: "Ticket",
                        principalColumn: "ticketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartTicketJoin_ticketId",
                table: "PartTicketJoin",
                column: "ticketId");
        }
    }
}
