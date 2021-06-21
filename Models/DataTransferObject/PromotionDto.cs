using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class PromotionDto
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
          public PromotionDto() { }

     }
}
