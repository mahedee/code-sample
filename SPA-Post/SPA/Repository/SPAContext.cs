using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPA.Repository
{
    public class SPAContext : DbContext
    {
        public SPAContext()
            : base("SPAContext")
        {
        }
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<SPA.Models.SPAContext>());

        public DbSet<SPA.Models.Trainer> Trainers { get; set; }

        public DbSet<SPA.Models.Training> Trainings { get; set; }
    }
}