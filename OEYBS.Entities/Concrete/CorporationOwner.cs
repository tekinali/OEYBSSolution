using OEYBS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Entities.Concrete
{
    [Table("CorporationOwners")]
    public class CorporationOwner : IEntity
    {
        [ForeignKey("AppUser")]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }      


        public AppUser AppUser { get; set; }
        public List<Corporation> Corporations { get; set; }

        public CorporationOwner()
        {
            Corporations = new List<Corporation>();
        }


    }
}
