using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Requests
{
    public class CreateManufactureWithModelRequest
    {
        public string manufacturerName { get; set; }
        public string modelName { get; set; }

        public CreateManufactureWithModelRequest () { }

        public CreateManufactureWithModelRequest (string manufacturerName, string modelName)
        {
            this.manufacturerName = manufacturerName;
            this.modelName = modelName;
        }
    }
}
