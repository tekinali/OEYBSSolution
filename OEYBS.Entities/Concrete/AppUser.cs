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
    [Table("AppUsers")]
    public class AppUser : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public List<UserRole> UserRoles { get; set; }

        public CorporationOwner CorporationOwner { get; set; }
        public Employee Employee { get; set; }
        public SystemAdministrator SystemAdministrator { get; set; }
        public SchoolManager SchoolManager { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }

        public AppUser()
        {
            UserRoles = new List<UserRole>();
        }


    }


}
