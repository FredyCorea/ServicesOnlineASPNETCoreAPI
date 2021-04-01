using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DTO
{
     public class GeoCityDto
     {
          public GeoCityDto(){}

          public int CityId { get; set; }
          public string Iatacode { get; set; }
          public string CityName { get; set; }
          public int? NationId { get; set; }
     }
}
