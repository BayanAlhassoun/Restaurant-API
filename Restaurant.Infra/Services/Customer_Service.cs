using Restaurant.Core.Data;
using Restaurant.Core.Repositories;
using Restaurant.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Services
{
    public class Customer_Service : ICustomer_Service
    {
        private readonly ICustomer_Repository _customer_Repository; // _customer_Repository =   new Customer_Repository();

        public Customer_Service(ICustomer_Repository customer_Repository) // customer_Repository= new Customer_Repository();
        {
            _customer_Repository = customer_Repository;
        }

        public void CreateCustomer(Customer customer)
        {
            _customer_Repository.CreateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customer_Repository.DeleteCustomer(id);
        }

        public List<Customer> GetAllCustomers()
        {
           return _customer_Repository.GetAllCustomers();
        }

        public int GetCstomersCount()
        {
            var result = _customer_Repository.GetAllCustomers().Count;
            return result;
        }

        public Customer GetCustomerById(int id)
        {
            return _customer_Repository.GetCustomerById(id);
        }

        public List<Customer> GetMaleCustomers()
        {
            var result = _customer_Repository.GetAllCustomers();
            result = result.Where(x => x.Gender_Id == 1).ToList();
            return result;
        }

        public void UpdateCustomer(Customer customer)
        {
            _customer_Repository.UpdateCustomer(customer);
        }
    }
}
