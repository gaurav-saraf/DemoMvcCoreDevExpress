using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test200Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    
}
