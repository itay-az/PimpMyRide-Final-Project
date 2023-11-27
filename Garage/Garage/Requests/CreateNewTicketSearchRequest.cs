using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Requests
{
    public class CreateNewTicketSearchRequest
    {
        public string clientId { get; set; }
        public string carNumber { get; set; }
        public string clientFullName { get; set; }
        public string clientPhoneNumber { get; set; }
        public string clientEmail { get; set; }
        public string clientManufacture { get; set; }
        public string clientModel { get; set; }
        public string clientYear { get; set; }
        public string clientEngine { get; set; }
        public string clientKM { get; set; }
    }
}
