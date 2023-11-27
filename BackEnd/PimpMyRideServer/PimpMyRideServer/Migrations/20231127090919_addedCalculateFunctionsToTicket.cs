using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class addedCalculateFunctionsToTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "totalLaborDiscount",
                table: "Ticket",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "totalLaborPrice",
                table: "Ticket",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "totalPartsDiscount",
                table: "Ticket",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "totalPartsPrice",
                table: "Ticket",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "totalLaborDiscount",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "totalLaborPrice",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "totalPartsDiscount",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "totalPartsPrice",
                table: "Ticket");
        }
    }
}
