using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Data;
using Restaurant.Core.Services;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer_Service _customer_Service; // = new Customer_Service();

        public CustomerController(ICustomer_Service customer_Service) // ICustomer_Service customer_Service = new Customer_Service();
        {
            _customer_Service = customer_Service;
        }

        [HttpGet]
       public List<Customer> GetAllCustomers() // https://localhost:7031/api/customer
        {
           return _customer_Service.GetAllCustomers();
        }

        [HttpPost]
        public void CreateCustomer(Customer customer) // https://localhost:7031/api/customer
        {
            _customer_Service.CreateCustomer(customer);  
        }

        [HttpPut]
        public void UpdateCustomer(Customer customer)
        {
            _customer_Service.UpdateCustomer(customer);
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            _customer_Service.DeleteCustomer(id);
        }

        [HttpGet]
        [Route("GetCustomerById/{id}")]
     
        public Customer GetById(int id) // https://localhost:7031/api/customer/GetCustomerById/20
        {
           return _customer_Service.GetCustomerById(id);
        }

    }
}
