using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Assingment_EFCore.WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class SalaryController : Controller
    {
        private readonly ISalaryService _salaryService;

        public SalaryController(ISalaryService salaryService)
        {
            _salaryService = salaryService;
        }

        [HttpGet]
        [Route("salaries")]
        public async Task<IActionResult> GetAllSalaries()
        {
            var response = await _salaryService.GetAllSalaries();
            return Ok(response);
        }

        [HttpGet]
        [Route("salary/{id}")]
        public async Task<ActionResult<SalaryResponse>> GetSalaryById(Guid id)
        {
            var response = await _salaryService.GetSalaryById(id);
            return Ok(response);
        }

        [HttpPost]
        [Route("salary")]
        public async Task<ActionResult<SalaryResponse>> CreateSalary([FromForm] SalaryRequest salaryRequest)
        {
            var response = await _salaryService.CreateSalary(salaryRequest);
            return Ok(response);
        }

        [HttpDelete]
        [Route("salary")]
        public async Task<ActionResult<bool>> DeleteSalary(Guid id)
        {
            var response = await _salaryService.DeleteSalary(id);
            return Ok(response);
        }

        [HttpPut]
        [Route("salary")]
        public async Task<ActionResult<SalaryResponse>> UpdateSalary(Guid id, [FromForm] SalaryRequest salaryRequest)
        {
            var response = await _salaryService.UpdateSalary(id, salaryRequest);
            return Ok(response);
        }
    }
}