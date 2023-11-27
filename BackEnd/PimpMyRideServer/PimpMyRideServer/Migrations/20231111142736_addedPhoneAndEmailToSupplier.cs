using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class addedPhoneAndEmailToSupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "supplierContact",
                table: "Suppliers",
                newName: "supplierPhone");

            migrationBuilder.AddColumn<string>(
                name: "supplierEmail",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "supplierEmail",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "supplierPhone",
                table: "Suppliers",
                newName: "supplierContact");
        }
    }
}
