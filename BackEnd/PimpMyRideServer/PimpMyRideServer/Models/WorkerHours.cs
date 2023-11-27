using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class WorkerHours
    {
        [Key] public int id { get; set; }

        [Required] public  DateTime entryTimeStamp { get; set; }

        [Required] public DateTime  exitTimeStamp { get; set; }

    }
}
