using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class addedStatePropToTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isOpen",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "state",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "state",
                table: "Ticket");

            migrationBuilder.AddColumn<bool>(
                name: "isOpen",
                table: "Ticket",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
