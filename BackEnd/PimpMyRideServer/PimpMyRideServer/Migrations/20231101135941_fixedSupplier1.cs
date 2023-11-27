using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class fixedSupplier1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Suppliers_supplierssupplierId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "supplierssupplierId",
                table: "Order",
                newName: "SupplierssupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_supplierssupplierId",
                table: "Order",
                newName: "IX_Order_SupplierssupplierId");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierssupplierId",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "supplierName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.DropColumn(
                name: "supplierName",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "SupplierssupplierId",
                table: "Order",
                newName: "supplierssupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_SupplierssupplierId",
                table: "Order",
                newName: "IX_Order_supplierssupplierId");

            migrationBuilder.AlterColumn<int>(
                name: "supplierssupplierId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Suppliers_supplierssupplierId",
                table: "Order",
                column: "supplierssupplierId",
                principalTable: "Suppliers",
                principalColumn: "supplierId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
