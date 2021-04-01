using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DTO
{
     public class ServiceMediaDto
     {
          public int ServiceMediaId { get; set; }
          public int? ServiceId { get; set; }
          public string MediaDescr { get; set; }
          public string UrlPath { get; set; }
          public DateTime? ValidFrom { get; set; }
          public DateTime? ValidUntil { get; set; }

          //public virtual Service Service { get; set; }

          public ServiceMediaDto()
          {

          }
     }
}
