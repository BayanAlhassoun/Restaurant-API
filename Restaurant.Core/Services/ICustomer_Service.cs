using Restaurant.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Services
{
    public interface ICustomer_Service
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
        List<Customer> GetMaleCustomers();
        int GetCstomersCount();
    }
}
