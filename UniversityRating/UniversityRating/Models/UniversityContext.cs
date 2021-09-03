using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityRating.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<University> Universities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}