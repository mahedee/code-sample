using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Repository
{
    public class DeptRepository : IDeptRepository
    {
        private readonly ApplicationDbContext _context;

        public DeptRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Dept GetDept(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Dept>> GetDepts()
        {
            return await _context.Dept.ToListAsync();
            //throw new NotImplementedException();
        }
    }
}
