using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DTO
{
     public class ShoppingCartDto
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
          //public virtual ICollection<PersonsRole> PersonsRoles { get; set; }
          public virtual Customer Customer { get; set; }
          public ShoppingCartDto()
          {

          }
     }
}
