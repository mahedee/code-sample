namespace Web.Mahedee.net.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Web.Mahedee.net.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.Mahedee.net.Models.InventoryDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Web.Mahedee.net.Models.InventoryDBContext context)
        {
            context.Categories.AddOrUpdate(
                p => p.Name,
                new Category
                {
                    Name = "Electronics",
                    Products = new List<Product> { 
                        new Product{Name = "Mobile"},
                        new Product{Name = "Laptop"},
                        new Product{Name = "Television"},
                        new Product{Name = "Camera"}
                    }

                },

                new Category
                {
                    Name = "Men ware",
                    Products = new List<Product> 
                    { 
                        new Product{Name = "Footware"},
                        new Product{Name = "Clothings"},
                        new Product{Name = "Watches"},
                        new Product{Name = "Hand bag"},
                        new Product{Name = "Sun Glass"}
                    }
                },

                new Category
                {
                    Name = "Baby & Kids",
                    Products = new List<Product> 
                    { 
                        new Product{Name = "Baby footware"},
                        new Product{Name = "Kids clothigs"},
                        new Product{Name = "Baby care"}
                    }
                },

                 new Category
                {
                    Name = "Books",
                    Products = new List<Product> 
                    { 
                        new Product{Name = "Introduction to C#"},
                        new Product{Name = "ASP.NET MVC Begineer to Professional"},
                        new Product{Name = "ASP.NET Web API Security"},
                        new Product{Name = "SPA with ASP.NET MVC"}
                    }
                }

                );
        }
    }
}
