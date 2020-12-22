using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Repository
{
    public interface IDeptRepository
    {
        //public List<Dept> GetDepts();
        public Task<List<Dept>> GetDepts();
        public Dept GetDept(int? id);

    }
}
