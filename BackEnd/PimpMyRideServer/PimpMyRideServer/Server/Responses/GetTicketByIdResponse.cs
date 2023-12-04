using PimpMyRideServer.Models;

namespace PimpMyRideServer.Server.Responses
{
    public class GetTicketByIdResponse
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
        public List<TicketPart> parts { get; set; }
        public List<TicketLabor> labors { get; set; }
        public string causeOfArrival { get; set; }

        public double totalPartsPrice { get; set; }
        public double totalPartsDiscount { get; set; }

        public double totalLaborPrice { get; set; }
        public double totalLaborDiscount { get; set; }

        public double price { get; set; }
        public TicketType state { get; set; }
    }
}
