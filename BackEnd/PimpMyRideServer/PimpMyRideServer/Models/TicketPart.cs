using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Models
{
    public class TicketPart
    {
        [Key]public int Id { get; set; }
        [Required] public string partId { get; set; } = null!;
        [Required] public string partName { get; set; }
        [Required] public decimal price { get; set; }
        [Required] public decimal quantity { get; set; }
        public decimal discount { get; set; }
        public decimal unitPrice { get; set; }

    }
}
