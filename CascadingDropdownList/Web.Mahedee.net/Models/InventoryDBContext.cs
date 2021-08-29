using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Web.Mahedee.net.Models
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}