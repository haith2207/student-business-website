using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SBWebsites.Controllers.Student;
using SBWebsites.Migrations;
using SBWebsites.Models;
using SBWebsites.Services;

namespace SBWebsites
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        SBWDataContext dbContext = new SBWDataContext();
        private Boolean run = true;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SBWDataContext, Configuration>());
            using (var context = new SBWDataContext())
            {
                context.Database.Initialize(true);
            }
            // set thread system
           // Thread abc = new Thread(checkDateTime);
          //  abc.Start();
           // JobService _jobService = new JobService();

            if (run)
            {
                SBWDataContext DB = new SBWDataContext();
                foreach (Job itemJob in DB.Jobs)
                {
                    if (itemJob.EndDate < DateTime.Now)
                    {
                        itemJob.Status = "Expired";
                        DB.Entry(itemJob).State = EntityState.Modified;
                        //Boolean rs = _jobService.Update(itemJob);
                        // gửi thông báo tới toàn bộ student apply job đó.
                        IEnumerable<JobStudent> dataStudents = DB.JobStudents.Where(s => s.JobId == itemJob.JobId);
                        foreach (JobStudent uTjobStudent in dataStudents)
                        {
                            Notification newNotification = new Notification();
                            newNotification.SenderUser = uTjobStudent.Job.UserName;
                            newNotification.ReceiveUser = uTjobStudent.UserStudent;
                            newNotification.Title = "Công việc hết hạn";
                            newNotification.ContentNoty = "Công việc " + uTjobStudent.Job.Name + " đã hết hạn ứng tuyển";
                            DB.Notifications.Add(newNotification);
                        }

                    }
                }
                try
                {
                    DB.SaveChanges();

                }
                catch (Exception)
                {
                }

                foreach (Job itemJob in DB.Jobs)
                {
                    if (!itemJob.Status.Equals("Expired"))
                    {
                        itemJob.SuggestQuantity = Suggest.SuggestStudentsforjob(itemJob.JobId);
                        try
                        {
                            DB.Entry(itemJob).State = EntityState.Modified;
                        }
                        catch (Exception)
                        {
                        }
                    }

                }
                foreach (Student itemStudent in DB.Students)
                {
                    int rs = Suggest.SuggestJobforStudent(itemStudent.UserName);
                }
                try
                {
                    DB.SaveChanges();
                }
                catch (Exception)
                {

                }

                run = false;
            }

           
           

        }

        //private void checkDateTime()
        //{

        //    while (true)
        //    {
        //        DateTime current = DateTime.Now;
        //        if (current.Hour == 4 || current.Hour == 16)
        //        {
        //            SBWDataContext DB = new SBWDataContext();

        //            // check datetime of job
        //            foreach (Job itemJob in DB.Jobs)
        //            {
        //                if (itemJob.EndDate < DateTime.Now)
        //                {
        //                    itemJob.Status = "Expired";
        //                    DB.Entry(itemJob).State = EntityState.Modified;
        //                    //Boolean rs = _jobService.Update(itemJob);
        //                }
        //            }
        //            DB.SaveChanges();
        //            // check event
        //            foreach (Event itemEvent in DB.Events)
        //            {
        //                if (itemEvent.EndDate < DateTime.Now)
        //                {
        //                    itemEvent.Status = "Expired";
        //                    DB.Entry(itemEvent).State = EntityState.Modified;
        //                    //Boolean rs = _jobService.Update(itemJob);
        //                }
        //            }
        //            DB.SaveChanges();
        //        }

        //        Thread.Sleep(1800000);
        //    }

        //}

        //private void checkSuggestJob(Object User)
        //{
        //    string dataUser = (string)User;
        //    while (true)
        //    {

        //        StudentMngController dataController = new StudentMngController();

        //        Thread.Sleep(60000);
        //    }
        //}



    }
}