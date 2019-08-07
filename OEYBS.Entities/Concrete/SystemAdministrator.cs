using OEYBS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Entities.Concrete
{
    [Table("SystemAdministrators")]
    public class SystemAdministrator : IEntity
    {
        [ForeignKey("AppUser")]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public AppUser AppUser { get; set; }
    }
}
