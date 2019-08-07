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
    [Table("ClassroomTypes")]
    public class ClassroomType : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Classroom> Classrooms { get; set; }

        public ClassroomType()
        {
            Classrooms = new List<Classroom>();
        }


    }
}
