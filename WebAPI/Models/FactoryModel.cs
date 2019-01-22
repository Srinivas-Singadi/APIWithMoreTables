using CircularReffrenceError;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class FactoryModel
    {
        public CustomerModel create(Customer customer)
        {
            return new CustomerModel
            {
                customerid = customer.CustomerID,
                customName = customer.CustomerName,

                //Taking the input from the Entity model and giving the result as api model
                hardware = customer.Hardware1.Select(h => create(h)),
                software = customer.Softwares.Select(s => create(s))
            };
        }


        public HardwareModel create(Hardware1 hardware)
        {
            return new HardwareModel
            {
                hardwareid = hardware.HardwareID,
                hardware= hardware.Hardware
            };
        }

        public SoftwareModel create(Software software)
        {
            return new SoftwareModel
            {
                softwareid = software.SoftwaeID,
                software = software.Software1
            };
        }

        public Hardware1 Post(HardwareModel hardware1)
        {
            return new Hardware1
            {
                HardwareID = hardware1.hardwareid,
                Hardware = hardware1.hardware
            };
        }

        public Software Post(SoftwareModel software)
        {
            return new Software
            {
                SoftwaeID = software.softwareid,
                Software1= software.software
            };
        }
    }
}