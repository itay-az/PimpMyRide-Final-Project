using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class addedOrderPartModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Part_Order_orderId",
                table: "Part");

            migrationBuilder.DropIndex(
                name: "IX_Part_orderId",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "orderId",
                table: "Part");

            migrationBuilder.CreateTable(
                name: "OrderPart",
                columns: table => new
                {
                    partId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    partName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    orderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPart", x => x.partId);
                    table.ForeignKey(
                        name: "FK_OrderPart_Order_orderId",
                        column: x => x.orderId,
                        principalTable: "Order",
                        principalColumn: "orderId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPart_orderId",
                table: "OrderPart",
                column: "orderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPart");

            migrationBuilder.AddColumn<int>(
                name: "orderId",
                table: "Part",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Part_orderId",
                table: "Part",
                column: "orderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Order_orderId",
                table: "Part",
                column: "orderId",
                principalTable: "Order",
                principalColumn: "orderId");
        }
    }
}
