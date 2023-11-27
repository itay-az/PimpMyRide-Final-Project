using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Requests
{
    public class GetModelsByManufactureRequest
    {
        public int id { get; set; }
        public string manufacturerName { get; set; }
        public string model { get; set; }
    }
}

