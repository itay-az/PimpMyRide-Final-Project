using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class AllOrder
    {
        public int orderId { get; set; }
        public string supplierName { get; set; }
        public string date { get; set; }
        public double price { get; set; }
    }
}
