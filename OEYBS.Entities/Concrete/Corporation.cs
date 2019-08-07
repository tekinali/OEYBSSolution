using OEYBS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Entities.Concrete
{
    [Table("Corporations")]
    public class Corporation : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime StartOfContractDate { get; set; }
        public DateTime EndOfContractDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Location { get; set; }
        public string TaxNumber { get; set; }
        public string DepartmentofTaxation { get; set; }

        public CorporationOwner CorporationOwner { get; set; }
        public Guid CorporationOwnerId { get; set; }

        public List<CorporationTeacher> CorporationTeachers { get; set; }
        public List<CorporationEmployee> CorporationEmployees { get; set; }
        public List<CorporationSchoolManager> CorporationSchoolManagers { get; set; }
        public List<CorporationStudent> CorporationStudents { get; set; }

        public List<CorporationAddress> CorporationAddresses { get; set; }
        public List<Classroom> Classrooms { get; set; }
        public List<Education> Educations { get; set; }

        public Corporation()
        {
            CorporationTeachers = new List<CorporationTeacher>();
            CorporationEmployees = new List<CorporationEmployee>();
            CorporationSchoolManagers = new List<CorporationSchoolManager>();
            CorporationStudents = new List<CorporationStudent>();

            CorporationAddresses = new List<CorporationAddress>();
            Classrooms = new List<Classroom>();
            Educations = new List<Education>();
        }

    }
}
