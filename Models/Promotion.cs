using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
     public partial class Promotion
     {

          public int PromotionsId { get; set; }
          public int? ServiceId { get; set; }
          public string PromDescr { get; set; }
          public int? DaysBefore { get; set; }
          public int? SalesRatio { get; set; }
          public int? Discount { get; set; }
          public DateTime? ValidFrom { get; set; }
          public DateTime? ValidUntil { get; set; }

          //public virtual Service Service { get; set; }

          public Promotion() { }

     }
}
