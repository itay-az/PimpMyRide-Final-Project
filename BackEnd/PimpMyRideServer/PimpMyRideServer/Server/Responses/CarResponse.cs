using PimpMyRideServer.Models;
using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Server.Responses
{
    public class CarResponse
    {

        public CarResponse(string carId, string carManufacture, string carModel, string carEngine, int carYear, int carKilometer, string vinNumber)
        {
            this.carId = carId;
            this.carManufacture = carManufacture;
            this.carModel = carModel;
            this.carEngine = carEngine;
            this.carYear = carYear;
            this.carKilometer = carKilometer;
            this.vinNumber = vinNumber;
        }

        public string carId { get; set; } = null!;

        public string carManufacture { get; set; } = null!;
        public string carModel { get; set; } = null!;

        public string carEngine { get; set; } = null!;

        public int carYear { get; set; }

        public int carKilometer { get; set; }

        public string vinNumber { get; set; } = null!;
    }
}
