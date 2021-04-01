using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class View1
    {
        public int ShopCartId { get; set; }
        public int? PersonId { get; set; }
        public string PersonName { get; set; }
        public string LastName { get; set; }
        public DateTime? ShopDate { get; set; }
        public string ServicesName { get; set; }
        public int? Quantity { get; set; }
        public string ListName { get; set; }
        public decimal Price { get; set; }
        public string StateName { get; set; }
    }
}
