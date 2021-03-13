
using System.Collections.Generic;
using System.Threading.Tasks;
using HRM.Models;

namespace HRM.Repository
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> SelectAllEmployees();
        
    }
}
