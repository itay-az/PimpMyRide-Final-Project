using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PimpMyRideServer.Migrations
{
    /// <inheritdoc />
    public partial class deletedNotUsedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarService");

            migrationBuilder.DropTable(
                name: "ManualLabor");

            migrationBuilder.DropTable(
                name: "WorkerHours");

            migrationBuilder.DropTable(
                name: "Worker");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "ManualLabor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    time = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualLabor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bankAccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    hourFee = table.Column<float>(type: "real", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seniority = table.Column<float>(type: "real", nullable: false),
                    workerAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workerPosition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "WorkerHours",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Workerid = table.Column<int>(type: "int", nullable: true),
                    entryTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    exitTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_WorkerHours_Workerid",
                table: "WorkerHours",
                column: "Workerid");
        }
    }
}
