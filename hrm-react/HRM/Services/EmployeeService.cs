using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HRM.Models;
using HRM.Repository;

namespace HRM.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _employeeRepository = repository;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
                return await _employeeRepository.SelectAllEmployees();
            }
            catch(Exception exp)
            {
                throw (exp);
            }
        }
    }
}