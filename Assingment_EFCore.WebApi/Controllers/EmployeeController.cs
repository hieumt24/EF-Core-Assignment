using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Assingment_EFCore.WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeSerivce _employeeSerivce;

        public EmployeeController(IEmployeeSerivce employeeSerivce)
        {
            _employeeSerivce = employeeSerivce;
        }

        [HttpGet]
        [Route("employees")]
        public async Task<IActionResult> GetAllEmployee()
        {
            var response = await _employeeSerivce.GetAllEmployee();
            return Ok(response);
        }

        [HttpPost]
        [Route("employee")]
        public async Task<ActionResult<CreateEmployeeResponse>> CreateEmployee([FromBody] CreateEmployeeRequest employeeRequest)
        {
            var response = await _employeeSerivce.CreateEmployee(employeeRequest);
            return Ok(response);
        }

        [HttpPut]
        [Route("employee")]
        public async Task<ActionResult<CreateEmployeeResponse>> UpdateEmployee(Guid id, [FromBody] CreateEmployeeRequest employeeRequest)
        {
            var response = await _employeeSerivce.UpdateEmployee(id, employeeRequest);
            return Ok(response);
        }

        [HttpGet]
        [Route("employee/{id}")]
        public async Task<ActionResult<CreateEmployeeResponse>> GetEmployeeById(Guid id)
        {
            var response = await _employeeSerivce.GetEmployeeById(id);
            return Ok(response);
        }

        [HttpDelete]
        [Route("employee")]
        public async Task<ActionResult<bool>> DeleteEmployee(Guid id)
        {
            var response = await _employeeSerivce.DeleteEmployee(id);
            return Ok(response);
        }
    }
}