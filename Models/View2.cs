using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class View2
    {
        public int? OrdersHdrId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? Amount { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }
}
