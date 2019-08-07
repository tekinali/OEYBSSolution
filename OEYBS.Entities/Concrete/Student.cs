using OEYBS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Entities.Concrete
{
    [Table("Students")]
    public class Student : IEntity
    {
        [ForeignKey("AppUser")]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public string FathersName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string ParentsFullName { get; set; }
        public string ParentsIdentificationNumber { get; set; }
        public string SchoolStatus { get; set; }
        public string PayStatus { get; set; }
        public string ServiceStatus { get; set; }

        public AppUser AppUser { get; set; }

        public List<StudentReport> StudentReports { get; set; }
        public List<CorporationStudent> CorporationStudents { get; set; }

        public Student()
        {
            StudentReports = new List<StudentReport>();
            CorporationStudents = new List<CorporationStudent>();
        }

    }
}
