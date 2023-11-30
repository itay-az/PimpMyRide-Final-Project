using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class ticketChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "clientEmail",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "clientPhone",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clientEmail",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "clientPhone",
                table: "Ticket");
        }
    }
}
