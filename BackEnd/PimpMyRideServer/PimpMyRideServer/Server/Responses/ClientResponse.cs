using PimpMyRideServer.Server.Responses;
using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Server.NewFolder
    {
        public class ClientResponse
        {

            public ClientResponse(string id, string name, string phone, string email,string address, List<CarResponse> cars) { 

                this.name=name;
                this.id = id;
                this.phone=phone;
                this.email=email;
                this.address=address;
                this.cars=cars;
            }
            public string id { get; set; } = null!;
            public string name { get; set; } = null!;
            public string phone { get; set; } = null!;
            public string? email { get; set; }
            public string? address { get; set; }
            public List<CarResponse> cars { get; set; }
        }
    }
