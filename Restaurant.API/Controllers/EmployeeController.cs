using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Data;
using Restaurant.Core.Services;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee_Service _employee_Service;

        public EmployeeController(IEmployee_Service employee_Service)
        {
            _employee_Service = employee_Service;
        }

        [HttpGet]
        [Route("GetEmployeesBySalary/{salary}")]
        public List<Employee> GetEmployeesBySalary(int salary) // https://localhost:7031/api/employee/GetEmployeesBySalary/5000
        {
            return _employee_Service.GetEmployeesBySalary(salary);
        }
    }
}
