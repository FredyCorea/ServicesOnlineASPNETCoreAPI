using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class UnitOfMeasureDto
     {
          public UnitOfMeasureDto()
          {
               //ServiceDurUoms = new HashSet<Service>();
               //ServiceUnitOfMeasures = new HashSet<Service>();
          }

          public int UoMid { get; set; }
          public string UomName { get; set; }

          //public virtual ICollection<Service> ServiceDurUoms { get; set; }
          //public virtual ICollection<Service> ServiceUnitOfMeasures { get; set; }
     }
}
