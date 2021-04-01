using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class CctransactionDto
     {
          public int CctransactId { get; set; }
          public int? OrdersHdrId { get; set; }
          public string Ccresponse { get; set; }
          public decimal? Amount { get; set; }
          public DateTime? ResponseDate { get; set; }

          public virtual OrdersHeader OrdersHdr { get; set; }
     }
}
