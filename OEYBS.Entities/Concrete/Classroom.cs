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
    [Table("Classrooms")]
    public class Classroom : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public int Total { get; set; }
        public string Description { get; set; }

        public int ClassroomTypeId { get; set; }
        public ClassroomType ClassroomType { get; set; }

        public Guid CorporationId { get; set; }
        public Corporation Corporation { get; set; }
    }
}
