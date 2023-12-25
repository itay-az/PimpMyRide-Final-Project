using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class addedLaborsOnCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Labor",
                columns: new[] { "Id", "description", "discount", "price", "time" },
                values: new object[,]
                {
                    { 1, "15K Service", 0.0m, 300m, 1.0m },
                    { 2, "30K Service", 0.0m, 450m, 1.5m },
                    { 3, "45K Service", 0.0m, 600m, 2.0m },
                    { 4, "60K Service", 0.0m, 600m, 2.0m },
                    { 5, "75K Service", 0.0m, 300m, 1.0m },
                    { 6, "90K Service", 0.0m, 900m, 3.0m },
                    { 7, "105K Service", 0.0m, 450m, 1.5m },
                    { 8, "Brake pads Replacement", 0.0m, 300m, 1.0m },
                    { 9, "Brake rotors and pads Replacement", 0.0m, 450m, 1.5m },
                    { 10, "Axle Replacement", 0.0m, 300m, 1.0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Labor",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
