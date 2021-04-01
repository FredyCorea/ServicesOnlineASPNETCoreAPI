using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models
{
     public class Customer
     {
               public Customer()
               {                    
                    //Entity = new HashSet<Entity>();
               }

               public int CustomerId { get; set; }
               public string CustomerName { get; set; }
               //public string LastName { get; set; }
               //public int RoomId { get; set; }

               //public virtual ICollection<PersonsRole> PersonsRoles { get; set; }
               //public virtual ICollection<Entity> Entity { get; set; }
       
     }
}
