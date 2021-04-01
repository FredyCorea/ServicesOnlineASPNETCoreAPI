using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
     public partial class ServiceSched
     {
          ServiceSched() { }
          public int ServiceSchedId { get; set; }
          public int? ServiceId { get; set; }
          public DateTime? FromDate { get; set; }
          public DateTime? UntilDate { get; set; }
          public int? Capacity { get; set; }

          //public virtual Service Service { get; set; }
     }
}
