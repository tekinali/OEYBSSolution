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
    [Table("Teachers")]
    public class Teacher : IEntity
    {
        [ForeignKey("AppUser")]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
  
        public AppUser AppUser { get; set; }
        public List<TeacherField> TeacherFields { get; set; }
        public List<CorporationTeacher> CorporationTeachers { get; set; }

        public Teacher()
        {
            TeacherFields = new List<TeacherField>();
            CorporationTeachers = new List<CorporationTeacher>();
        }

    }
}
