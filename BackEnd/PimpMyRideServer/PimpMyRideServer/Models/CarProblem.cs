using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class CarProblem
    {
        [Key] public int id { get; set; }

        [Required] public string carProblem { get; set; }

    }
}
