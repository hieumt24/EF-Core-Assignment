using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Assingment_EFCore.WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        /// <summary>
        /// Get All Departments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("departments")]
        public async Task<IActionResult> GetAllDepartments()
        {
            var response = await _departmentService.GetAllDepartments();
            return Ok(response);
        }

        /// <summary>
        /// Get Department By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("department/{id}")]
        public async Task<ActionResult<DepartmentResponse>> GetDepartmentById(Guid id)
        {
            var response = await _departmentService.GetDepartmentById(id);
            return Ok(response);
        }

        /// <summary>
        /// Add new department
        /// </summary>
        /// <param name="departmentRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("department")]
        public async Task<ActionResult<DepartmentResponse>> CreateDepartment([FromForm] DepartmentRequest departmentRequest)
        {
            var response = await _departmentService.CreateDepartment(departmentRequest);
            return Ok(response);
        }

        /// <summary>
        /// Update new department
        /// </summary>
        /// <param name="id"></param>
        /// <param name="departmentRequest"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("department")]
        public async Task<ActionResult<DepartmentResponse>> UpdateDepartment(Guid id, [FromForm] DepartmentRequest departmentRequest)
        {
            var response = await _departmentService.UpdateDepartment(id, departmentRequest);

            return Ok(response);
        }

        /// <summary>
        /// Delete department
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("departmen")]
        public async Task<ActionResult<bool>> DeleteDepartment(Guid id)
        {
            var response = await _departmentService.DeleteDepartment(id);
            return Ok(response);
        }
    }
}