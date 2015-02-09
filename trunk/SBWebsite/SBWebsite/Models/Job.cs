using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SBWebsite.Models
{
    public class Job
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float Salary { get; set; }
        public string CatID { get; set; }
        public string LocationID { get; set; }
        public string TimeID { get; set; }
        public string EmpID { get; set; }
        public DateTime DatePost { get; set; }
        public DateTime DateExpired { get; set; }
        public string Status { get; set;}
        public string Requiments {get; set;}

    }

    public class SBWebsiteContext:DbContext
    {
        public DbSet<Job> Jobs { get; set; }
    }
}