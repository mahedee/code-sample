namespace Web.OData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Web.OData.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.OData.Models.HRMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Web.OData.Models.HRMContext context)
        {

            context.Employees.AddOrUpdate(
              p => p.Name,
              new Employee { Name = "Mahedee Hasan", Designation = "Software Architect", Dept = "SSD", BloodGroup = "A+" },
              new Employee { Name = "Kazi Aminur Rashid", Designation = "AGM", Dept = "SSD", BloodGroup = "NA" },
              new Employee { Name = "Tauhidul Haque", Designation = "DGM", Dept = "SSD", BloodGroup = "A+" }
            );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
