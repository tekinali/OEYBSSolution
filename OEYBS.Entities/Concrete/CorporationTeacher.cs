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
    [Table("CorporationTeachers")]
    public class CorporationTeacher : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid CorporationId { get; set; }
        public Corporation Corporation { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
