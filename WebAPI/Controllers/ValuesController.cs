using CircularReffrenceError;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using CircularReffrenceError.Model;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {

        FactoryModel _FactoryModel;
        CircularRepository cr = new CircularRepository();
        public ValuesController()
        {
            this._FactoryModel = new FactoryModel();
        }
        // GET api/values
        public IEnumerable<CustomerModel> Get()
        {
            
            //return cr.Get().ToList().Select(c => _FactoryModel.create(c));

            return cr.Get().ToList().Select(c => _FactoryModel.create(c));

        }

        // GET api/values/5
        public IEnumerable<CustomerModel> Get(int id)
        {
            CircularRepository cr = new CircularRepository();

            return cr.GetByID(id).ToList().Select(i => _FactoryModel.create(i));
        }

        // POST api/values
        public void Post(CustomerDTO customer)
        {
            CustomerPurchaseEntities db = new CustomerPurchaseEntities();

            try
            {
                var cust = new Customer {
                    CustomerID = customer.customerid,
                    CustomerName = customer.customName
                };
                db.Customers.Add(cust);

                Hardware1 cust1 = new Hardware1();
                cust1.CustomerID = customer.customerid;
                cust1.HardwareID = customer.hardware.HardwareID;
                cust1.Hardware = customer.hardware.Hardware;

                db.Hardware1.Add(cust1);

                var cust2 = new Software();

                cust2.CustomerID = customer.customerid;
                cust2.SoftwaeID = customer.software.SoftwaeID;
                cust2.Software1 = customer.software.Software1;

                db.Softwares.Add(cust2);

                db.SaveChanges();
                  
                
            }
            catch (Exception)
            {

            }

            //Customer cust = new Customer();
            //cust.CustomerID = customer.customerid;
            //cust.CustomerName = customer.customName;
            //cust.Hardware1 = null;
            //cust.Softwares = null;


            //db.Customers.Add(cust);
            //db.SaveChanges();
            //Hardware1 hardware1 = new Hardware1();
            //hardware1.CustomerID = customer.customerid;
            //hardware1.Hardware = customer.hardware.Select(h => _FactoryModel.Post(h)).ToString();
            //hardware1.Customer = cust;
            //db.Hardware1.Add(hardware1);
            //db.SaveChanges();

            //Software software = new Software();
            //software.CustomerID = customer.customerid;
            //software.Software1 = customer.software.Select(s => _FactoryModel.Post(s)).ToString();
            //software.Customer = cust;
            //db.Softwares.Add(software);


            //db.SaveChanges();

            //Customer customer = new Customer();
            //customer.CustomerID = customerModel.customerid;
            //customer.CustomerName = customerModel.customName;
            //customer.Hardware1 = (customerModel.hardware.Select(h => _FactoryModel.Post(h)).ToList());
            //customer.Softwares = (customerModel.software.Select(s => _FactoryModel.Post(s)).ToList());
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
