using CustomerMicroService.Database;
using CustomerMicroService.DatabaseContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CustomerMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        // GET: CustomerController
        private CustomerContext _customerContext;

        public CustomerController(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerContext.Customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerContext.Customers.FirstOrDefault(s => s.CustomerId == id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _customerContext.Customers.Add(value);
            _customerContext.SaveChanges();
        }
    }
}
