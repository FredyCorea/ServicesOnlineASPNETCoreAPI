using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
     public partial class Address
     {
         
          public int AddressId { get; set; }
          public string Address1 { get; set; }
          public string Address2 { get; set; }
          public string City { get; set; }
          public int? StateId { get; set; }
          public string County { get; set; }    //not to confuse it wity Country
          public int? NationId { get; set; }
          public string ZipCode { get; set; }

          public virtual GeoNation Nation { get; set; }
          public virtual State State { get; set; }

     }
}
