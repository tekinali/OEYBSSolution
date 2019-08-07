using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OEYBS.Entities.Concrete;
using OEYBS.Business.Abstract;
using OEYBS.WebUI.Areas.SystemAdministrator.ViewModels.Corporation;
using System.Net;

namespace OEYBS.WebUI.Areas.SystemAdministrator.Controllers
{
    public class CorporationController : Controller
    {
        private ICorporationService _corporationService;
        private ICorporationOwnerService _corporationOwnerService;
        private ICorporationTeacherService _corporationTeacherService;
        private ICorporationEmployeeService _corporationEmployeeService;

        private ICorporationSchoolManagerService _corporationSchoolManagerService;
        private ICorporationAddressService _corporationAddressService;
        private IClassroomService _classroomService;
        private IEducationService _educationService;

        private ICorporationStudentService _corporationStudentService;

        public CorporationController(ICorporationService corporationService, ICorporationOwnerService corporationOwnerService, 
            ICorporationTeacherService corporationTeacherService, ICorporationEmployeeService corporationEmployeeService, ICorporationSchoolManagerService corporationSchoolManagerService,
            ICorporationAddressService corporationAddressService, IClassroomService classroomService, IEducationService educationService, ICorporationStudentService corporationStudentService)
        {
            _corporationService = corporationService;
            _corporationOwnerService = corporationOwnerService;
            _corporationTeacherService = corporationTeacherService;
            _corporationEmployeeService = corporationEmployeeService;

            _corporationSchoolManagerService = corporationSchoolManagerService;
            _corporationAddressService = corporationAddressService;
            _classroomService = classroomService;
            _educationService = educationService;

            _corporationStudentService = corporationStudentService;
        }

        public ActionResult List()
        {
            var model = new ListViewModel();
            model.Corporations = _corporationService.GetAll().OrderBy(x=>x.Name).ToList();

            return View(model);
        }

        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var corporation = _corporationService.Find(x => x.Id == id);

            if(corporation==null)
            {
                return HttpNotFound();
            }

            var ownerId = corporation.CorporationOwnerId;
            
            DetailsViewModel model = new DetailsViewModel();

            model.Corporation = corporation;
            model.Owner = _corporationOwnerService.Find(x => x.Id == corporation.CorporationOwnerId);
            model.Teachers = _corporationTeacherService.ListWithDetails(x => x.CorporationId == corporation.Id).Select(t => t.Teacher).ToList();
            model.Employees = _corporationEmployeeService.ListWithDetails(x => x.CorporationId == corporation.Id).Select(e => e.Employee).ToList();

            model.SchoolManagers = _corporationSchoolManagerService.ListWithDetails(x => x.CorporationId == corporation.Id).Select(s => s.SchoolManager).ToList();
            model.Students = _corporationStudentService.ListWithDetails(x => x.CorporationId == corporation.Id).Select(s => s.Student).ToList();
            model.Addresses = _corporationAddressService.List(x => x.CorporationId == corporation.Id);
            model.Classrooms = _classroomService.List(x => x.CorporationId == corporation.Id);

            model.Educations = _educationService.List(x => x.CorporationId == corporation.Id);


            return View(model);
        }

    }
}