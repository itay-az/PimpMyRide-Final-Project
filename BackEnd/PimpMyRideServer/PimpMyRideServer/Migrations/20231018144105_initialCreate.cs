using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarProblems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carProblem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarProblems", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CarService",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarService", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CauseOfArrival",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauseOfArrival", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.clientId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacture",
                columns: table => new
                {
                    manufacturerName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacture", x => x.manufacturerName);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    manufacturerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    partName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    supplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supplierAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supplierContact = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.supplierId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workerPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workerAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankAccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    hourFee = table.Column<float>(type: "real", nullable: false),
                    seniority = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    carId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    clientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    carManufacture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carEngine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carYear = table.Column<int>(type: "int", nullable: false),
                    carKilometer = table.Column<int>(type: "int", nullable: false),
                    vinNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.carId);
                    table.ForeignKey(
                        name: "FK_Car_Clients_clientId",
                        column: x => x.clientId,
                        principalTable: "Clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkerHours",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    entryTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    exitTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Workerid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerHours", x => x.id);
                    table.ForeignKey(
                        name: "FK_WorkerHours_Worker_Workerid",
                        column: x => x.Workerid,
                        principalTable: "Worker",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "Manufacture",
                column: "manufacturerName",
                values: new object[]
                {
                    "BMW",
                    "Mazda",
                    "Toyota"
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "manufacturerName", "model" },
                values: new object[,]
                {
                    { 1, "Mazda", "3" },
                    { 2, "Mazda", "6" },
                    { 3, "Mazda", "CX-5" },
                    { 4, "BMW", "3 Series" },
                    { 5, "BMW", "4 Series" },
                    { 6, "BMW", "5 Series" },
                    { 7, "Toyota", "Corolla" },
                    { 8, "Toyota", "Auris" },
                    { 9, "Toyota", "Verso" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_clientId",
                table: "Car",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerHours_Workerid",
                table: "WorkerHours",
                column: "Workerid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "CarProblems");

            migrationBuilder.DropTable(
                name: "CarService");

            migrationBuilder.DropTable(
                name: "CauseOfArrival");

            migrationBuilder.DropTable(
                name: "Manufacture");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WorkerHours");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Worker");
        }
    }
}
