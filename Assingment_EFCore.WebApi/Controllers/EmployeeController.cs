﻿using Assingment_EFCore.Application.Interfaces;
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
    }
}