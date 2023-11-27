using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class changedSupplierIdToStringAndPartId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SupplierssupplierId",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    supplierId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    supplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supplierAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplierContact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.supplierId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_SupplierssupplierId",
                table: "Order",
                column: "SupplierssupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Suppliers_SupplierssupplierId",
                table: "Order",
                column: "SupplierssupplierId",
                principalTable: "Suppliers",
                principalColumn: "supplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Suppliers_SupplierssupplierId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Order_SupplierssupplierId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "SupplierssupplierId",
                table: "Order");
        }
    }
}
