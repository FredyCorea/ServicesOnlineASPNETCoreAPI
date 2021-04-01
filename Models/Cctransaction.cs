using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class Cctransaction
    {
        public int CctransactId { get; set; }
        public int? OrdersHdrId { get; set; }
        public string Ccresponse { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ResponseDate { get; set; }

        public virtual OrdersHeader OrdersHdr { get; set; }
    }
}
