using HRM.Models;
using HRM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services
{
    public class DeptService : IDeptService
    {
        private readonly IDeptRepository _repository;

        public DeptService(IDeptRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Dept>> GetDepts()
        {
            return await _repository.GetDepts();
        }

        public async Task<Dept> GetDept(int? id)
        {
            return await _repository.GetDept(id);
        }

        public async Task Add(Dept dept)
        {
            await _repository.Save(dept);
        }
    }
}
