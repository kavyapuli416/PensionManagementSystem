using Microsoft.AspNetCore.Mvc;
using PensionManagement.API.Data;

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
    }
}
