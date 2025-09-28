using Restaurant.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Services
{
    public interface IEmployee_Service
    {
        List<Employee> GetEmployeesBySalary(int salary);
    }
}
