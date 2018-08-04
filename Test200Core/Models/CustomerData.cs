using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test200Core.Models
{
    public class CustomerData
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Customer customer = null;
            for (int i = 1; i <= 100; i++)
            {
                customer =
                    new Customer
                    {
                        CustomerId = i,
                        Name = "Customer " + i.ToString(),
                        EmailAddress = "emailaddress" + i.ToString() + ".gmail.com",
                        City = "City " + i.ToString(),
                        CreatedOn = new DateTime(2018, 08, 04)
                    };
                customers.Add(customer);
            }
            return customers;
        }
    }
}
