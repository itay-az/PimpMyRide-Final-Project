using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class addedTicketLabor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labor_Ticket_ticketId",
                table: "Labor");

            migrationBuilder.DropIndex(
                name: "IX_Labor_ticketId",
                table: "Labor");

            migrationBuilder.DropColumn(
                name: "ticketId",
                table: "Labor");

            migrationBuilder.CreateTable(
                name: "TicketLabor",
                columns: table => new
                {
                    laborId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    time = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ticketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketLabor", x => x.laborId);
                    table.ForeignKey(
                        name: "FK_TicketLabor_Ticket_ticketId",
                        column: x => x.ticketId,
                        principalTable: "Ticket",
                        principalColumn: "ticketId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketLabor_ticketId",
                table: "TicketLabor",
                column: "ticketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketLabor");

            migrationBuilder.AddColumn<int>(
                name: "ticketId",
                table: "Labor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Labor_ticketId",
                table: "Labor",
                column: "ticketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Labor_Ticket_ticketId",
                table: "Labor",
                column: "ticketId",
                principalTable: "Ticket",
                principalColumn: "ticketId");
        }
    }
}
