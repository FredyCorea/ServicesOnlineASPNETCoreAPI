using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class Entity
    {
        public Entity()
        {
            //OrdersHeaders = new HashSet<OrdersHeader>();
            //ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int EntityId { get; set; }
        public int? PersonId { get; set; }
        public int? PropertyId { get; set; }
        public int? LocationId { get; set; }

        //public virtual Location Location { get; set; }
        //public virtual ICollection<OrdersHeader> OrdersHeaders { get; set; }
        //public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
