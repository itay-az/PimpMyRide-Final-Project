using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class ticketChanged1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "clientFullName",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clientFullName",
                table: "Ticket");
        }
    }
}
