using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SBWebsite.Models;

namespace SBWebsite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Data db = new Data();

        public ActionResult Index()
        {
            ViewBag.a = db.ROLES.ToList();
            return View();
        }

    }
}
