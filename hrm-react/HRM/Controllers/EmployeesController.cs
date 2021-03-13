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
             var allemployess = _employeeService.GetEmployees();
             return Ok(allemployess);
        }
        catch(Exception exp)
        {
            return BadRequest(exp.Message);
        }
        //return await _context.Employees.ToListAsync();
    }

    // [HttpGet("[action]")]
    // public IActionResult GetEmployees()
    // {
    //     try
    //     {
    //         //throw new Exception();
    //         var allemployess = _context.Employees.ToListAsync();
    //         return Ok(allemployess);
    //     }
    //     catch (Exception exp)
    //     {
    //         return BadRequest(exp.Message);
    //     }

    // }

}