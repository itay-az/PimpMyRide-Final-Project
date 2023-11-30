using System;
using System.Collections.Generic;
using Garage.Models;

namespace Garage.Models
{
    public class Ticket
    {
        public int ticketId { get; set; }
        public string carId { get; set; }
        public string clientId { get; set; }
        public List<CauseOfArrival> problems { get; }
        public List<Parts> parts { get; }
        public List<Labor> labors { get; }
        public DateTime dateTime { get; set; }
        public double price { get; set; }
        public TicketType state { get; set; }
    }
}
