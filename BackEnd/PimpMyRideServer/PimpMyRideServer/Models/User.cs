using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace PimpMyRideServer.Models
{
    public class User
    {
        [Key] public int Id { get; set; }
        [Required] public string UserName { get; set; }
        [Required] public string Password { get; set; }

        public string Email { get; set; }

        [Required]
        [EnumDataType(typeof(JobTitle))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public JobTitle JobTitle { get; set; }
    }
}
