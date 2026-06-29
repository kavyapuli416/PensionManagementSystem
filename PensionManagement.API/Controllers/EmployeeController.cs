using Microsoft.AspNetCore.Mvc;
using PensionManagement.API.Data;
using PensionManagement.API.Models;

namespace PensionManagement.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
          var employees=_context.Employees.ToList();
           return Ok(employees);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok(employee);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _context.Employees.Find(id);
            if(employee == null)
            {
                return NotFound("Employee Not Found");
            }
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id,Employee updatedEmployee)
        {
            var employee= _context.Employees.Find(id);
            if(employee == null)
            {
                return NotFound("Employee Not Found");
            }
            employee.EmployeeCode = updatedEmployee.EmployeeCode;
            employee.EmployeeName = updatedEmployee.EmployeeName;
            employee.Email = updatedEmployee.Email;
            employee.PhoneNumber = updatedEmployee.PhoneNumber;
            employee.DateOfBirth = updatedEmployee.DateOfBirth;
            employee.JoiningDate = updatedEmployee.JoiningDate;
            employee.Salary = updatedEmployee.Salary;
            employee.Department = updatedEmployee.Department;
            employee.Designation = updatedEmployee.Designation;
            employee.IsActive = updatedEmployee.IsActive;

            _context.SaveChanges();
            return Ok(employee);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return NotFound("Employee not found.");
            }

            _context.Employees.Remove(employee);

            _context.SaveChanges();

            return Ok("Employee deleted successfully.");
        }
    }
}
