using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DTO
{
     public class LocationTypeDto
     {
          public LocationTypeDto()
          {
               //Locations = new HashSet<Location>();
          }

          public int LocTypeId { get; set; }
          public string LocTypeName { get; set; }

          //public virtual ICollection<Location> Locations { get; set; }
     }
}
