using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Requests
{
    public class CreateNewPartRequest
    {
        public string partId { get; set; }
        public string partName { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
    }
}
