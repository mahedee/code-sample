
using System.Collections.Generic;
using System.Threading.Tasks;
using HRM.Models;

namespace HRM.Repository
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> SelectAllEmployees();
        public Task<Employee> SelectEmployee(int id);
        public Task<string> UpdateEmployee(int id, Employee employee);
        public Task<string> SaveEmployee(Employee employee);
         public Task<string> DeleteEmployee(int id);

    }
}
