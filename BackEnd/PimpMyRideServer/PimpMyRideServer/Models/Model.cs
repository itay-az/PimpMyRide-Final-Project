using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class Model
    {
        [Key] public int Id { get; set; }
        [Required] public string manufacturerName { get; set; }
        [ForeignKey("manufacturerName")]

        [Required] public string model { get; set;}

        public Model() { }


    }
}
