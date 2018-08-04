using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Test200Core.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Test200Core.Controllers {

    [Route("api/[controller]")]
    public class CustomerController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(CustomerData.GetCustomers(), loadOptions);
        }

    }
}