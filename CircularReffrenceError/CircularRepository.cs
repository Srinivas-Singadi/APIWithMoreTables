using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CircularReffrenceError
{
    public class CircularRepository
    {

        CustomerPurchaseEntities db = new CustomerPurchaseEntities();
        
        public IQueryable<Customer> Get()
        {
            
            var customer = db.Customers;
            return customer;
        }

        public IQueryable<Customer> GetByID(int ID)
        {
            var cust = db.Customers.Where(x => x.CustomerID == ID).Select(e => e);
            return cust;
        }

        //public void Post(CustomerModel customer)
        //{
        //    Customer cust = new Customer();
        //    cust.CustomerID = customer.CustomerID;
        //    cust.CustomerName = customer.CustomerName;

        //    cust.Hardware1 = customer.Hardware1;
        //    cust.Softwares = customer.Softwares;

        //    db.SaveChanges();
        //}

    }
}
