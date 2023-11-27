using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class noKeyForTicketPart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Part_partId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketPart_Ticket_ticketId",
                table: "TicketPart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketPart",
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

            migrationBuilder.DropColumn(
                name: "discount",
                table: "Part");

            migrationBuilder.AlterColumn<string>(
                name: "partId",
                table: "TicketPart",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "partId",
                table: "TicketPart",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AddColumn<decimal>(
                name: "discount",
                table: "Part",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketPart",
                table: "TicketPart",
                column: "partId");

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
    }
}
