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

        public async Task<List<Dept>> GetDepts()
        {
            return await _context.Dept.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<Dept> GetDept(int? id)
        {
            var dept = await _context.Dept
                 .FirstOrDefaultAsync(m => m.Id == id);

            return dept;
        }

        public async Task Save(Dept dept)
        {
            _context.Add(dept);
            await _context.SaveChangesAsync();
        }
    }
}
