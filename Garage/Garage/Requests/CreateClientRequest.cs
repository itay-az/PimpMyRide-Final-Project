using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Requests
{
    public class CreateClientRequest
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string carId { get; set; }
        public string carManufacture { get; set; }
        public string carModel { get; set; }
        public string carEngine { get; set; }
        public int carYear { get; set; }
        public int carKilometer { get; set; }
        public string vinNumber { get; set; }

    }
}
