using Garage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Responses
{
    public class GetAllTicketsResponse
    {
        public int ticketId { get; set; }
        public string carId { get; set; }
        public string clientId { get; set; }
        public string problems { get; set; }
        public List<Parts> parts { get; set; }
        public List<Labor> labors { get; set; }
        public DateTime dateTime { get; set; }
        public double price { get; set; }
    }
}
