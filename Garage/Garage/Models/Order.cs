using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public List<Parts> parts { get; set; }
        public string supplierName { get; set; }
        public double price { get; set; }
        public DateTime dateTime { get; set; }
    }
}
