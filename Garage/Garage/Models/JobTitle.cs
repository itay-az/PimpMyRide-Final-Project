using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Garage.Models.JobTitleClass;

namespace Garage.Models
{
    public class JobTitleClass
    {
        public enum JobTitle
        {
            Manager,
            ServiceAdvisor,
            Warehouse

        }
        public static JobTitle GetValue(string value)
        {
            return value == JobTitle.Manager.ToString() ? JobTitle.Manager : value == JobTitle.ServiceAdvisor.ToString() ? JobTitle.ServiceAdvisor : JobTitle.Warehouse;
        }
        public static int GetIntValue(string value)
        {
            return value == JobTitle.Manager.ToString() ? 0 : value == JobTitle.ServiceAdvisor.ToString() ? 1 : 2;        
        }
        

    }
}
