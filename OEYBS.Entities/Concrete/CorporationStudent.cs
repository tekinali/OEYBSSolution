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
    [Table("CorporationStudents")]
    public class CorporationStudent : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid CorporationId { get; set; }
        public Corporation Corporation { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
