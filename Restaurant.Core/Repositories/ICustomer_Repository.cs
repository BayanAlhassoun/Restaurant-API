using Restaurant.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Repositories
{
    public interface ICustomer_Repository
    {
       List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
       void CreateCustomer(Customer customer);
        void UpdateCustomer (Customer customer);
        void DeleteCustomer (int id);
        List<User> GetAllUsers();
        User GetUserById(int id);


    }
}
