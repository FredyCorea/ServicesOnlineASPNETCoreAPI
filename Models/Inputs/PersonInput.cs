using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.Inputs
{
     public class PersonInput
     {
          public PersonInput() { }
          //  public int PersonId { get; set; }
          public string PersonName { get; set; }
          public string LastName { get; set; }
          public int RoomId { get; set; }
     }
}
