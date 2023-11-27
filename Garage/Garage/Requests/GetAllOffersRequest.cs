using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Requests
{
    public class GetAllOffersRequest
    {
        public string offerId {  get; set; }
        public string clientId { get; set; }
        public DateTime createdAt { get; set; }

    }
}
