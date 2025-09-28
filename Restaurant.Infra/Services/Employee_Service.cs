using Restaurant.Core.Data;
using Restaurant.Core.Repositories;
using Restaurant.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Services
{
    public class Employee_Service : IEmployee_Service
    {
        private readonly IEmployee_Repository _employee_Repository;

        public Employee_Service(IEmployee_Repository employee_Repository)
        {
            _employee_Repository = employee_Repository;
        }

        public List<Employee> GetEmployeesBySalary(int salary)
        {
            return _employee_Repository.GetEmployeesBySalary(salary);
        }
    }
}
