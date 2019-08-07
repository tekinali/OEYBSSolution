using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OEYBS.Business.Abstract;
using OEYBS.Entities.Concrete;

namespace OEYBS.WebUI.Controllers
{
    public class TestController : Controller
    {
        private IAppRoleService _appRoleService;
        private IAppUserService _appUserService;
        private ISchoolManagerService _corporationManagerService;

        public TestController(IAppRoleService appRoleService, IAppUserService appUserService, ISchoolManagerService corporationManagerService)
        {
            _appRoleService = appRoleService;
            _appUserService = appUserService;
            _corporationManagerService = corporationManagerService;
        }

        public ActionResult Index()
        {
            var data = _appRoleService.GetAll();

            //var user1 = new AppUser()
            //{
            //    UserName = "Yonetici",
            //    Password = "11",
            //    Email = "yonetici@yonetici.com",
            //    IsActive = true                
            //};

            //var usr1 = _appUserService.Add(user1);

            //var manager1 = new SchoolManager()
            //{
            //    FirstName="YoneticiAd1",
            //    LastName="YoneticiSoyad",
            //    Id=usr1.Id
            //};

            //var mngr = _corporationManagerService.Add(manager1);
            

            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Features()
        {
            return View();
        }

        public ActionResult References()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


    }
}