using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class Order
    {
        public int OrdersId { get; set; }
        public int? OrdersHdrId { get; set; }
        public int? ServiceId { get; set; }
        public int? StateId { get; set; }
        public DateTime? Shipped { get; set; }
        public DateTime? Delivered { get; set; }

        public virtual OrdersHeader OrdersHdr { get; set; }
        public virtual Service Service { get; set; }
        public virtual TransactState State { get; set; }
    }
}
