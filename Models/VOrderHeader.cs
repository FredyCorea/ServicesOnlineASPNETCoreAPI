using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class VOrderHeader
    {
        public int OrdersHdrId { get; set; }
        public string PersonName { get; set; }
        public string LastName { get; set; }
        public DateTime? OrderDate { get; set; }
        public string StateName { get; set; }
    }
}
