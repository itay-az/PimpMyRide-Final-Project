using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Requests
{
    public class GetAllSuppliersRequest
    {
        public string supplierId { get; set; }
        public string supplierName { get; set; }
        public string supplierAddress { get; set; }
        public string supplierPhone { get; set; }
        public string supplierEmail { get; set; }
        public List<Order> orders { get; set; }
    }
}
