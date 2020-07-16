using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMS.Web.Db;
using SMS.Web.Model;

namespace SMS.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly SMSContext _context;

        public TeachersController(SMSContext context)
        {
            _context = context;
        }

        // GET: api/Teachers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        // GET: api/Teachers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetTeacher(int id)
        {
            var teacher = await _context.Posts.FindAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return teacher;
        }

        // PUT: api/Teachers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacher(int id, Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return BadRequest();
            }

            _context.Entry(teacher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Teachers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Teacher>> PostTeacher(Teacher teacher)
        {
            _context.Posts.Add(teacher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeacher", new { id = teacher.Id }, teacher);
        }

        // DELETE: api/Teachers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Teacher>> DeleteTeacher(int id)
        {
            var teacher = await _context.Posts.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(teacher);
            await _context.SaveChangesAsync();

            return teacher;
        }

        private bool TeacherExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}
