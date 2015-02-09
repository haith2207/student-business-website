using SBWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SBWebsite.Controllers
{
    public class EmployerController : Controller
    {
    
        public ActionResult CreateJob()
        {
            return View("CreateJob");
        }
        [HttpPost]
        public ActionResult CreateJob(CreateJobViewModel model)
        {
            if (ModelState.IsValid)
            {
                //check date
             //   if (model.EndTime != null)
            //    {
                /// =   var compareTo = model.StartTime.CompareTo(model.EndTime);
                  //  if (compareTo > 0)
                 //   {
                    //    ModelState.AddModelError("", "Ngày kết thúc sau ngày bắt đầu");
                //        return View("CreateContest", model);
               //     }
             //   }

                //create db
                return RedirectToAction("Index");
            }
            return View("CreateJob", model);
        }

         
    
}
}