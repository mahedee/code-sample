using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HRM.Db;
using HRM.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HRMContext _context;

        public EmployeeRepository(HRMContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> SelectAllEmployees()
        {
            try
            {
                var allemployess = _context.Employees.ToListAsync();
                return await allemployess;
            }
            catch (Exception exp)
            {
                throw (exp);
            }
        }

        public async Task<Employee> SelectEmployee(int id)
        {
            try
            {
                var employee = _context.Employees.FindAsync(id);
                return await employee;
            }
            catch (Exception exp)
            {
                throw (exp);
            }
        }

        
    }
}