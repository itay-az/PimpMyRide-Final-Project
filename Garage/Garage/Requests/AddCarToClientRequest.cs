using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Requests
{
    public class AddCarToClientRequest
    {
        public string carId { get; set; }
        public string clientId { get; set; }
        public string carManufacture { get; set; }
        public string carModel { get; set; }
        public string carEngine { get; set; }
        public int carYear { get; set; }
        public int carKilometer { get; set; }
        public string vinNumber { get; set; }
        public DateTime dateTime { get; set; }
        public List<int> ticketIds { get; set; } = new List<int>();
    }
}
