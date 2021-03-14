using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HRM.Db;
using HRM.Models;
using HRM.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
public class EmployeesController : Controller
{

    private readonly IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
    {
        try
        {
             var allemployess = await _employeeService.GetEmployees();
             return Ok(allemployess);
        }
        catch(Exception exp)
        {
            return BadRequest(exp.Message);
        }
        //return await _context.Employees.ToListAsync();
    }

    
    [HttpGet("Employee/{id}")]
    public async Task<ActionResult<Employee>> GetEmployeeById(int id)
    {
        try
        {
            var employee = await _employeeService.GetEmployee(id);
            return Ok(employee);
        }
        catch(Exception exp)
        {
            return BadRequest(exp.Message);
        }
    }

    [HttpPost("AddEmployee")]
    public async Task<ActionResult> AddEmployee([FromBody]Employee employee)
    {
        try
        {
            string result = string.Empty;
            if(employee != null)
            {
                result = await _employeeService.AddEmployee(employee);
            }
            return Ok(result);
        }
        catch(Exception exp)
        {
            return BadRequest(exp.Message);
            //
        }
    }

    [HttpPut("EditEmployee/{id}")]
    public async Task<ActionResult> EditEmployee(int id, [FromBody]Employee employee)
    {
        try
        {
            string result = string.Empty;
            result = await _employeeService.EditEmployee(id, employee);
            return Ok(result);
        }
        catch(Exception exp)
        {
            return BadRequest(exp.Message);
        }
    }

    [HttpDelete("DeleteEmployee/{id}")]
    public async Task<ActionResult> DeleteEmployee(int id)
    {
        try
        {
            string result = string.Empty;
            result = await _employeeService.RemoveEmployee(id);
            return Ok(result);
        }
        catch(Exception exp)
        {
            return BadRequest(exp.Message);
        }
    }

}