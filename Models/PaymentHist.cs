using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
     public partial class PaymentHist
     {
          public int PaymentsId { get; set; }
          public int? OrdersHdrId { get; set; }
          public DateTime? PaymentDate { get; set; }
          public int? PaymntStateId { get; set; }
          public decimal? Amount { get; set; }

          public virtual OrdersHeader OrdersHdr { get; set; }
          public virtual TransactState PaymntState { get; set; }
     }
}
