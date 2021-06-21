using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class EntityDto
     {

          public EntityDto()
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
