using Garage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Responses
{
    public class GetAllOrdersResponse
    {
        public int orderId { get; set; }
        public List<Parts> parts { get; set; }
        public string supplierName { get; set; }
        public double price { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;
    }
}
