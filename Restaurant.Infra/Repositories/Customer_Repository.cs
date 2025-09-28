using Dapper;
using Microsoft.EntityFrameworkCore;
using Restaurant.Core.Common;
using Restaurant.Core.Data;
using Restaurant.Core.Repositories;
using Restaurant.Infra.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Repositories
{
    public class Customer_Repository : ICustomer_Repository
    {

        private readonly IDBContext _dBContext; // new DBContext()

        public Customer_Repository(IDBContext dBContext) //IDBContext dBContext  = new DBContext(), DBContext dBContext  = new DBContext()
        {
            _dBContext = dBContext;
        }

        public void CreateCustomer(Customer customer)
        {
           var p = new DynamicParameters();
            p.Add("C_name", customer.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_phone", customer.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_email", customer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_gender", customer.Gender_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Execute("Customer_Package.CreateCustomer", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteCustomer(int id)
        {
            var p = new DynamicParameters();
            p.Add("c_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Execute("Customer_Package.DeleteCustomer", p, commandType: CommandType.StoredProcedure);
        }

        public List<Customer> GetAllCustomers()
        {
            var result = _dBContext.Conection.Query<Customer>("Customer_Package.GetAllCustomers" , commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Query<Customer>("Customer_Package.GetCustomerById", p, commandType: CommandType.StoredProcedure); // {}
            return result.FirstOrDefault();
        }

        public void UpdateCustomer(Customer customer)
        {
            var p = new DynamicParameters();
            p.Add("C_ID", customer.Customer_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("C_name", customer.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_phone", customer.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_email", customer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("C_gender", customer.Gender_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Execute("Customer_Package.UpdateCustomer", p, commandType: CommandType.StoredProcedure);
        }
    }
}
