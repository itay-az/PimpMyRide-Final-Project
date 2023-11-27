using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class Worker
    {
        [Key]  public int id { get; set; }
        [Required] public string name { get; set; } = null!;

        [Required] public string workerPosition { get; set; } = null!;

        [Required] public string? workerAdress { get; set; }

        [Required] public string? workerEmail { get; set; }

        [Required] public string? workerPhone { get; set;}

        [Required] public long bankAccountNumber { get; set; }

        [Required] public float hourFee { get; set; }

        [Required] public float seniority { get; set; }

        [Required] public List<WorkerHours> workerHour { get; set; } = new List<WorkerHours>();

    }
}
