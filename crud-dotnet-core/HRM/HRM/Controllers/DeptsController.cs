using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HRM.Data;
using HRM.Models;
using HRM.Services;

namespace HRM.Controllers
{
    public class DeptsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IDeptService _deptService;

        public DeptsController(ApplicationDbContext context, IDeptService deptService)
        {
            _context = context;
            _deptService = deptService;
        }

        // GET: Depts
        public async Task<IActionResult> Index()
        {
            return View(await _deptService.GetDepts());
            //return View(await _context.Dept.ToListAsync());
        }

        // GET: Depts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var dept = await _context.Dept
            //    .FirstOrDefaultAsync(m => m.Id == id);
            var dept = await _deptService.GetDept(id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        // GET: Depts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Depts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Dept dept)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(dept);
                //await _context.SaveChangesAsync();
                await _deptService.Add(dept);
                return RedirectToAction(nameof(Index));
            }
            return View(dept);
        }

        // GET: Depts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dept = await _context.Dept.FindAsync(id);
            if (dept == null)
            {
                return NotFound();
            }
            return View(dept);
        }

        // POST: Depts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Dept dept)
        {
            if (id != dept.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dept);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeptExists(dept.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dept);
        }

        // GET: Depts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dept = await _context.Dept
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        // POST: Depts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dept = await _context.Dept.FindAsync(id);
            _context.Dept.Remove(dept);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeptExists(int id)
        {
            return _context.Dept.Any(e => e.Id == id);
        }
    }
}
