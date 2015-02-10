namespace SBWebsite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SBWebsite.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<SBWebsite.Models.Data>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SBWebsite.Models.Data context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

             context.ROLES.AddOrUpdate(

                  new ROLE { ROLE_SEQ = 1, ROLE_NAME = "Admin" },
                  new ROLE { ROLE_SEQ =2,ROLE_NAME = "Employer" },
                  new ROLE { ROLE_SEQ =3,ROLE_NAME = "Student" }
                );

            context.SaveChanges();
            base.Seed(context);
   
        }
    }
}
