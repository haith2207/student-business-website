using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SBWebsite.Models;

namespace SBWebsite.CreateData
{
    public class DBInitializer : DropCreateDatabaseAlways<SBWDataEntities>
    {
        protected override void Seed(SBWDataEntities context)
        {
            IList<ROLE> roles = new List<ROLE>();

            roles.Add(new ROLE() { ROLE_SEQ = 1, ROLE_NAME = "Admin" });
            roles.Add(new ROLE() { ROLE_SEQ = 2, ROLE_NAME = "Employer" });
            roles.Add(new ROLE() { ROLE_SEQ = 3, ROLE_NAME = "Students" });

            foreach (ROLE std in roles)
                context.ROLES.Add(std);

            base.Seed(context);
        }
    }
}