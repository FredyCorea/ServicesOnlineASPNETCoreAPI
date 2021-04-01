using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DTO
{
     public class PriceListDto
     {
          public PriceListDto()
          {
               //ShoppingCarts = new HashSet<ShoppingCart>();
          }

          public int PriceListId { get; set; }
          public int ServiceId { get; set; }
          public string ListName { get; set; }
          public decimal Price { get; set; }
          public DateTime? ValidFrom { get; set; }
          public DateTime? ValidUntil { get; set; }
     }
}
