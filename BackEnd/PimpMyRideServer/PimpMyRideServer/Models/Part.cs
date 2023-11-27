using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class Part
    {
        [Key] public string partId { get; set; } = null!;
        [Required] public string partName { get; set; }
        [Required] public decimal price { get; set; }
        [Required] public decimal quantity { get; set; }
    }
}
