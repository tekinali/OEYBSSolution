using OEYBS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Entities.Concrete
{
    [Table("Employees")]
    public class Employee : IEntity
    {
        [ForeignKey("AppUser")]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public AppUser AppUser { get; set; }
        public List<CorporationEmployee> CorporationEmployees { get; set; }
        public List<EmployeeJob> EmployeeJobs { get; set; }

        public Employee()
        {
            CorporationEmployees = new List<CorporationEmployee>();
            EmployeeJobs = new List<EmployeeJob>();
        }
    }
}
