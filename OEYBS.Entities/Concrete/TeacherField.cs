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
    [Table("TeacherFields")]
    public class TeacherField : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int EducationBranchId { get; set; }
        public EducationBranch EducationBranch { get; set; }


    }
}
