using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Models.DTOs;
using Assingment_EFCore.Application.Models.Requests;
using Assingment_EFCore.Application.Models.Response;
using Assingment_EFCore.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assingment_EFCore.WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeSerivce _employeeSerivce;
        private readonly LibraryDbContext _dbContext;

        public EmployeeController(IEmployeeSerivce employeeSerivce, LibraryDbContext dbContext)
        {
            _employeeSerivce = employeeSerivce;
            _dbContext = dbContext;
        }

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("employees")]
        public async Task<ActionResult> GetAllEmployee()
        {
            try
            {
                var response = await _employeeSerivce.GetAllEmployee();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        /// <summary>
        ///Create a new employee
        /// </summary>
        /// <param name="employeeRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("employee")]
        public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromForm] EmployeeRequest employeeRequest)
        {
            try
            {
                var response = await _employeeSerivce.CreateEmployee(employeeRequest);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        /// <summary>
        /// Update an employee
        /// </summary>
        /// <param name="id"></param>
        /// <param name="employeeRequest"></param>
        /// <returns></returns>

        [HttpPut]
        [Route("employee")]
        public async Task<ActionResult<EmployeeResponse>> UpdateEmployee(Guid id, [FromForm] EmployeeRequest employeeRequest)
        {
            try
            {
                var response = await _employeeSerivce.UpdateEmployee(id, employeeRequest);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        /// <summary>
        /// Get Employee By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("employee/{id}")]
        public async Task<ActionResult<EmployeeResponse>> GetEmployeeById(Guid id)
        {
            try
            {
                var response = await _employeeSerivce.GetEmployeeById(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        /// <summary>
        /// Delete an employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("employee")]
        public async Task<ActionResult<bool>> DeleteEmployee(Guid id)
        {
            try
            {
                var response = await _employeeSerivce.DeleteEmployee(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        /// <summary>
        /// Get employee with department
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("employeesWithDepartments")]
        public async Task<ActionResult<IEnumerable<EmployeeWithDepartmentDTO>>> GetEmployeesWithDepartments()
        {
            try
            {
                //var employeesWithDepartments = await (from emp in _dbContext.Employees
                //                                      join dept in _dbContext.Departments
                //                                      on emp.DepartmentId equals dept.Id
                //                                      select new EmployeeWithDepartmentDTO
                //                                      {
                //                                          EmployeeId = emp.Id,
                //                                          EmployeeName = emp.Name,
                //                                          DepartmentName = dept.Name
                //                                      }).ToListAsync();
                var employeesWithDepartments = await _employeeSerivce.GetEmployeesWithDepartments();

                return Ok(employeesWithDepartments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        /// <summary>
        /// employee with project
        /// </summary>
        /// <returns></returns>
        [HttpGet("employeesWithProjects")]
        public async Task<ActionResult<IEnumerable<EmployeeProjectsDto>>> GetEmployeesWithProjects()
        {
            try
            {
                var employeesWithProjects = _dbContext.Employees
                                                    .GroupJoin(
                                                           _dbContext.ProjectEmployees,
                                                           emp => emp.Id,
                                                           pe => pe.EmployeeId,
                                                           (emp, pes) => new
                                                           {
                                                               EmployeeId = emp.Id,
                                                               EmployeeName = emp.Name,
                                                               Projects = pes.Select(pe => pe.Project.Name).ToList()
                                                           }
                                                           )
                                                           .ToList();

                return Ok(employeesWithProjects);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        /// <summary>
        /// Get Employee Salary > 1000 and JoinedDate >= 2024-01-01
        /// </summary>
        /// <returns></returns>
        [HttpGet("SalaryAndDateCriteria")]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetEmployeeSalaryAndDateCriteria()
        {
            try
            {
                var employeesWithSalary = await _dbContext.Employees
                            .Join(
                                _dbContext.Salaries,
                                emp => emp.Id,
                                sal => sal.EmployeeId,
                                (emp, sal) => new
                                {
                                    EmployeeId = emp.Id,
                                    EmployeeName = emp.Name,
                                    EmployeeDepartmentId = emp.DepartmentId,
                                    EmployeeJoinedDate = emp.JoinedDate,
                                    SalaryAmount = sal.SalaryAmount
                                }
                            )
                            .ToListAsync();
                var response = employeesWithSalary.Where(x => x.SalaryAmount > 1000 && x.EmployeeJoinedDate >= new DateTime(2024, 1, 1));
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }
    }
}