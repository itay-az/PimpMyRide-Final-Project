using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Requests
{
    public class CreateNewOrderRequest
    {
        public List<Parts> parts { get; set; }
        public string supplierName { get; set; }
        public double price { get; set; }
    }
}
