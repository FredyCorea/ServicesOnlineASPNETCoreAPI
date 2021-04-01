using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class VOrdersDetail
    {
        public int OrdersId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? Shipped { get; set; }
        public DateTime? Delivered { get; set; }
        public string PersonName { get; set; }
        public string LastName { get; set; }
        public string ServicesName { get; set; }
        public string Requirements { get; set; }
        public int? Duration { get; set; }
    }
}
