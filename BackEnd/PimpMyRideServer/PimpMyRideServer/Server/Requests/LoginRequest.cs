namespace PimpMyRideServer.Server.Requests
{

    public class LoginRequest : Request
    {
        public string UserName { get; set; }
        public string Password { get; set; }


    }
}
