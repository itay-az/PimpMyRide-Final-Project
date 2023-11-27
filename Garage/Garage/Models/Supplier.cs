using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Supplier
    {
        public string supplierId { get; set; } = null!;
        public string supplierName { get; set; } = null!;
        public string supplierAddress { get; set; } = null!;
        public string supplierContact { get; set; } = null!;
        public List<Order> orders { get; set; }
    }
}
