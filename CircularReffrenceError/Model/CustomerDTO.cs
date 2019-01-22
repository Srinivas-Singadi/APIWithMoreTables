using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularReffrenceError;

namespace CircularReffrenceError.Model
{
    public class CustomerDTO
    {
        public int customerid { get; set; }
        public string customName { get; set; }

        public Hardware1 hardware { get; set; }
        public Software software { get; set; }
    }
}
