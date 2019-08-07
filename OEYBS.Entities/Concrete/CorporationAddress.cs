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
    [Table("CorporationAddresses")]
    public class CorporationAddress : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostCode { get; set; }
        public string Line { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumber2 { get; set; }

        public Guid CorporationId { get; set; }
        public Corporation Corporation { get; set; }
    }


}
