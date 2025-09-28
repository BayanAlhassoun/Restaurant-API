using Dapper;
using Restaurant.Core.Common;
using Restaurant.Core.Data;
using Restaurant.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Repositories
{
    public class EmployeeRepository: IEmployee_Repository
    {
        private readonly IDBContext _context;

        public EmployeeRepository(IDBContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployeesBySalary(int salary)
        {
            var p = new DynamicParameters();
            p.Add("salary_Value", salary, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _context.Conection.Query<Employee>("Employee_Package.GetEmployeesBySalary", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
