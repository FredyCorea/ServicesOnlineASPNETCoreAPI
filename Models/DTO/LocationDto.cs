using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class LocationDto
     {
          public LocationDto()
          {
               Entities = new HashSet<Entity>();
          }

          public int LocationId { get; set; }
          public string LocationName { get; set; }
          public int LocationTypeId { get; set; }

          public virtual LocationsType LocationType { get; set; }
          public virtual ICollection<Entity> Entities { get; set; }
     }
}
