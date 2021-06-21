using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class TransactStateDto
     {
          public TransactStateDto()
          {
               //Orders = new HashSet<Order>();
               //OrdersHeaders = new HashSet<OrdersHeader>();
               //PaymentHist = new HashSet<PaymentHist>();
               //ShoppingCarts = new HashSet<ShoppingCart>();
          }

          public int StateId { get; set; }
          public string StateCode { get; set; }
          public string StateName { get; set; }

          //public virtual ICollection<Order> Orders { get; set; }
          //public virtual ICollection<OrdersHeader> OrdersHeaders { get; set; }
          //public virtual ICollection<PaymentHist> PaymentHist { get; set; }
          //public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
     }
}
