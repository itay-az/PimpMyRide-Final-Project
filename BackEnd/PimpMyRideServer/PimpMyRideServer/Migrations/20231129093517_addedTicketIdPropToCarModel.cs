using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class addedTicketIdPropToCarModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ticketIds",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ticketIds",
                table: "Car");
        }
    }
}
