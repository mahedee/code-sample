using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Repository
{
    public interface IDeptRepository
    {
        public Task<List<Dept>> GetDepts();
        public Task<Dept> GetDept(int? id);

        public Task Save(Dept dept);

    }
}
