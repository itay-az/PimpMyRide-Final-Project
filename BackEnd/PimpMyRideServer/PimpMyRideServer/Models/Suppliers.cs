using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class Suppliers
    {
        [Key] public string supplierId { get;set; } = null!;
        [Required] public string supplierName { get; set; } = null!;
        public string? supplierAddress { get;set; } = null!;
        public string? supplierPhone { get; set; } = null!;
        public string? supplierEmail { get; set; } = null!;

        public List<Order>? orders { get; set; }

        public Suppliers()
        {
            this.orders = new List<Order>();
        }
    }
}
