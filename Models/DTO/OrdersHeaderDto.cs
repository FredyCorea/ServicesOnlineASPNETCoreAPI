using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DTO
{
     public class OrdersHeaderDto
     {
          public OrdersHeaderDto()
          {
               Cctransactions = new HashSet<Cctransaction>();
               Orders = new HashSet<Order>();
               PaymentHist = new HashSet<PaymentHistDto>();
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
          public virtual ICollection<PaymentHistDto> PaymentHist { get; set; }
     }
}
