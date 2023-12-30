using PimpMyRideServer.Models;
using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Server.Requests
{
    public class PutUserRequest : Request
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public JobTitle JobTitle { get; set; }

    }
}
