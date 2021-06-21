using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class ServiceSchedDto
     {
          ServiceSchedDto() { }
          public int ServiceSchedId { get; set; }
          public int? ServiceId { get; set; }
          public DateTime? FromDate { get; set; }
          public DateTime? UntilDate { get; set; }
          public int? Capacity { get; set; }
     }
}
