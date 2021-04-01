using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
     public partial class Person
     {
          public Person()
          {
               PersonsRoles = new HashSet<PersonsRole>();
               Entity = new HashSet<Entity>();
          }

          public int PersonId { get; set; }
          public string PersonName { get; set; }
          public string LastName { get; set; }
          public int RoomId { get; set; }

          public virtual ICollection<PersonsRole> PersonsRoles { get; set; }
          public virtual ICollection<Entity> Entity { get; set; }
     }
}
