using Microsoft.EntityFrameworkCore;
using SMS.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Web.Db
{
    public class SMSContext : DbContext
    {
        public SMSContext(DbContextOptions<SMSContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Users { get; set; }

        public DbSet<Teacher> Posts { get; set; }
    }
}
