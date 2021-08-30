using GenericRepo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepo.Repository
{
    public class GenericRepoContext : DbContext
    {
        public GenericRepoContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}