using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class GeoRegionDto
     {
          public GeoRegionDto() { }
          public int RegionId { get; set; }
          public string RegionName { get; set; }
     }
}
