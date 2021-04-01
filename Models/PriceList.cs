using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class PriceList
    {
        public PriceList()
        {
            //ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int PriceListId { get; set; }
        public int ServiceId { get; set; }
        public string ListName { get; set; }
        public decimal Price { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }

        //public virtual Service Service { get; set; }
        //public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
