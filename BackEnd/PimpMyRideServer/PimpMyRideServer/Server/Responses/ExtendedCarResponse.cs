namespace PimpMyRideServer.Server.Responses
{
    public class ExtendedCarResponse : CarResponse
    {
        public string clientId { get; set; }
        public string clientFullName { get; set; }
        public string clientPhoneNumber { get; set; }
        public string clientEmail { get; set; }

        public ExtendedCarResponse(string carId, string carManufacture, string carModel, string carEngine, int carYear, int carKilometer, string vinNumber, string clientId, string clientFullName, string clientPhoneNumber, string clientEmail) : 
            base(carId, carManufacture, carModel, carEngine, carYear, carKilometer, vinNumber)
        {
            this.clientId = clientId;
            this.clientFullName = clientFullName;
            this.clientPhoneNumber = clientPhoneNumber;
            this.clientEmail = clientEmail;
        }
    }
}
