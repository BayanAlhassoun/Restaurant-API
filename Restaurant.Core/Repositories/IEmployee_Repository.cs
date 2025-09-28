using Restaurant.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Repositories
{
    public interface IEmployee_Repository
    {
       List<Employee> GetEmployeesBySalary(int salary);
    }
}
