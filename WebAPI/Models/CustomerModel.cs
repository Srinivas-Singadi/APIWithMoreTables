using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class CustomerModel
    {
        public int customerid { get; set; }
        public string customName { get; set; }

        public IEnumerable<HardwareModel> hardware { get; set; }
        public IEnumerable<SoftwareModel> software { get; set; }
    }
}