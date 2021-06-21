using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class AddressDto
     {
          public int AddressId { get; set; }
          public string Address1 { get; set; }
          public string Address2 { get; set; }
          public string City { get; set; }
          public int? StateId { get; set; }
          //public string County { get; set; }
          public int? NationId { get; set; }
          public string ZipCode { get; set; }

          public virtual GeoNation Nation { get; set; }
          public virtual State State { get; set; }


     }
}
