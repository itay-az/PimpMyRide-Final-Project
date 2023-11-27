using PimpMyRideServer.Models;

namespace PimpMyRideServer.Server.Requests
{
    public class CreateNewTicketRequest : Request
    {
        public string carId { get; set; }
        public string clientId { get; set; }
        public string carManufacture { get; set; }
        public string carModel { get; set; }

        public string carEngine { get; set; }

        public int carYear { get; set; }

        public int carKilometer { get; set; }

        public string vinNumber { get; set; }

        public string clientFullName { get; set; }
        public string clientPhoneNumber { get; set; }
        public string clientEmail { get; set; }

        public string causeOfArrival { get; set; }

        public CreateNewTicketRequest(string carId, string carManufacture, string carModel, string carEngine, int carYear, int carKilometer, string vinNumber, string clientFullName, string clientPhoneNumber, string clientEmail, string causeOfArrival)
        {
            this.carId = carId;
            this.carManufacture = carManufacture;
            this.carModel = carModel;
            this.carEngine = carEngine;
            this.carYear = carYear;
            this.carKilometer = carKilometer;
            this.vinNumber = vinNumber;
            this.clientFullName = clientFullName;
            this.clientPhoneNumber = clientPhoneNumber;
            this.clientEmail = clientEmail;
            this.causeOfArrival = causeOfArrival;
        }
    }
}
