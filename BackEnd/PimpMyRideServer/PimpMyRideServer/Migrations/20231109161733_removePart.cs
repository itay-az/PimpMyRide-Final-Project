using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class removePart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CauseOfArrival_Ticket_ticketId",
                table: "CauseOfArrival");

            migrationBuilder.DropForeignKey(
                name: "FK_Labor_Ticket_ticketId",
                table: "Labor");

            migrationBuilder.DropTable(
                name: "TicketPart");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Suppliers");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Suppliers",
                columns: table => new
                {
                    supplierId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    supplierAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplierContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplierName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.supplierId);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    ticketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.ticketId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierssupplierId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    supplierName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Order_Suppliers_SupplierssupplierId",
                        column: x => x.SupplierssupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "supplierId");
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    partId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderId = table.Column<int>(type: "int", nullable: true),
                    partName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.partId);
                    table.ForeignKey(
                        name: "FK_Part_Order_orderId",
                        column: x => x.orderId,
                        principalTable: "Order",
                        principalColumn: "orderId");
                });

            migrationBuilder.CreateTable(
                name: "TicketPart",
                columns: table => new
                {
                    partspartId = table.Column<int>(type: "int", nullable: false),
                    ticketsticketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketPart", x => new { x.partspartId, x.ticketsticketId });
                    table.ForeignKey(
                        name: "FK_TicketPart_Part_partspartId",
                        column: x => x.partspartId,
                        principalTable: "Part",
                        principalColumn: "partId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketPart_Ticket_ticketsticketId",
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
                name: "IX_Order_SupplierssupplierId",
                table: "Order",
                column: "SupplierssupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Part_orderId",
                table: "Part",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketPart_ticketsticketId",
                table: "TicketPart",
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
    }
}
