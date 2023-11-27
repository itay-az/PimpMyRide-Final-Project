using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class addedUsingEntityToTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartTicket");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartTicket",
                columns: table => new
                {
                    partspartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "IX_PartTicket_ticketsticketId",
                table: "PartTicket",
                column: "ticketsticketId");
        }
    }
}
