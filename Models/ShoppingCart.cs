using ServicesOnLineAPI.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
     public partial class ShoppingCart
     {
          public int ShopCartId { get; set; }
          public int? EntityId { get; set; }
          public DateTime? ShopDate { get; set; }
          public int? ServiceId { get; set; }
          public int? Quantity { get; set; }
          public int? PriceListId { get; set; }
          public decimal? Discount { get; set; }
          public int? StateId { get; set; }

          public virtual Entity Entity { get; set; }
          public virtual PriceList PriceList { get; set; }
          public virtual Service Service { get; set; }

          public virtual TransactState State { get; set; }


          //public virtual Customer Customer { get; set; }
          //public virtual Location Location { get; set; }

          //public virtual ICollection<Customer> Customer { get; set; }

          public ShoppingCart()
          {
               //Customer = new HashSet<Customer>();
          }

     }
}
