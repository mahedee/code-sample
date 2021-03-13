using System.Collections.Generic;
using System.Threading.Tasks;
using HRM.Models;

namespace HRM.Services
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetEmployees();

    }
}
