using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class OrdersHeader
    {
        public OrdersHeader()
        {
            Cctransactions = new HashSet<Cctransaction>();
            Orders = new HashSet<Order>();
            PaymentHist = new HashSet<PaymentHist>();
        }

        public int OrdersHdrId { get; set; }
        public int? EntityId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? StateId { get; set; }
        public DateTime? Shipped { get; set; }
        public DateTime? Delivered { get; set; }

        public virtual Entity Entity { get; set; }
        public virtual TransactState State { get; set; }
        public virtual ICollection<Cctransaction> Cctransactions { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PaymentHist> PaymentHist { get; set; }
    }
}
