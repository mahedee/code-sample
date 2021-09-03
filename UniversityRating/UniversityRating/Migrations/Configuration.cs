namespace UniversityRating.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UniversityRating.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UniversityRating.Models.UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UniversityRating.Models.UniversityContext context)
        {
            context.Categories.AddOrUpdate(
                c => c.Name,
                new Category { Name = "Engineering" },
                new Category { Name = "Medical" },
                new Category { Name = "Agricultural" },
                new Category { Name = "General" }
                );

            context.Countries.AddOrUpdate(
             cn => cn.Name,
             new Country { Name = "Bangladesh" },
             new Country { Name = "America" },
             new Country { Name = "England" },
             new Country { Name = "Japan" }
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
