using PimpMyRideServer.Models;

namespace PimpMyRideServer.Server.Responses
{
    public class TicketWithPartResponse
    {
        public int ticketId { get; set; }
        public string carId { get; set; }
        public string clientId { get; set; }
        public string problems { get; set; }
        public List<PartResponse> parts { get; set; }
        public List<Labor> labors { get; set; }
        public DateTime dateTime { get; set; }
        public double price { get; set; }
    }
}
