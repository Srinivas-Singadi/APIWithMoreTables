//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CircularReffrenceError
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hardware1
    {
        public int HardwareID { get; set; }
        public int CustomerID { get; set; }
        public string Hardware { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
