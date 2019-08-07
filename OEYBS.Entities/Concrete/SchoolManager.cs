using OEYBS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Entities.Concrete
{
    [Table("SchoolManagers")]
    public class SchoolManager :  IEntity
    {
        [ForeignKey("AppUser")]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    
        public AppUser AppUser { get; set; }
        public List<CorporationSchoolManager> CorporationSchoolManagers { get; set; }

        public SchoolManager()
        {
            CorporationSchoolManagers = new List<CorporationSchoolManager>();
        }

    }
}
