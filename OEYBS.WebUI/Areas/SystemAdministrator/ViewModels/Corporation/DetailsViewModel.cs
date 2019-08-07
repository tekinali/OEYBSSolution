using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OEYBS.Entities.Concrete;

namespace OEYBS.WebUI.Areas.SystemAdministrator.ViewModels.Corporation
{
    public class DetailsViewModel
    {
        public Entities.Concrete.Corporation Corporation { get; set; }
        public CorporationOwner Owner { get; set; }
        public List<Entities.Concrete.Teacher> Teachers { get; set; }
        public List<Entities.Concrete.Employee> Employees { get; set; }

        public List<Entities.Concrete.SchoolManager> SchoolManagers { get; set; }
        public List<Entities.Concrete.Student> Students { get; set; }
        public List<CorporationAddress> Addresses { get; set; }
        public List<Classroom> Classrooms { get; set; }

        public List<Education> Educations { get; set; }



    }
}