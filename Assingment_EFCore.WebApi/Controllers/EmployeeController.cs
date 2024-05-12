using Assingment_EFCore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Assingment_EFCore.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]s/[action]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeSerivce _employeeSerivce;

        public EmployeeController(IEmployeeSerivce employeeSerivce)
        {
            _employeeSerivce = employeeSerivce;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var response = await _employeeSerivce.GetAllEmployee();
            return Ok(response);
        }
    }
}