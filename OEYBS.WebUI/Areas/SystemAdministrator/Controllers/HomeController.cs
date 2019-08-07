using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OEYBS.WebUI.Areas.SystemAdministrator.Controllers
{
    public class HomeController : Controller
    {
        // GET: SystemAdministrator/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}