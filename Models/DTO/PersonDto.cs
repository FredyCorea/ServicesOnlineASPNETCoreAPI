using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DTO
{
     public class PersonDto
     {
          public PersonDto() { }
          public int PersonId { get; set; }
          public string PersonName { get; set; }
          public string LastName { get; set; }
          public int RoomId { get; set; }

          public virtual ICollection<PersonsRole> PersonsRoles { get; set; }
          public virtual ICollection<Entity> Entity { get; set; }

     }
}
