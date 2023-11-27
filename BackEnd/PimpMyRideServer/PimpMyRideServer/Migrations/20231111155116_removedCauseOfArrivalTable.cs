using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class removedCauseOfArrivalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CauseOfArrival");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CauseOfArrival",
                columns: table => new
                {
                    CauseOfArrivalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ticketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauseOfArrival", x => x.CauseOfArrivalId);
                    table.ForeignKey(
                        name: "FK_CauseOfArrival_Ticket_ticketId",
                        column: x => x.ticketId,
                        principalTable: "Ticket",
                        principalColumn: "ticketId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CauseOfArrival_ticketId",
                table: "CauseOfArrival",
                column: "ticketId");
        }
    }
}
