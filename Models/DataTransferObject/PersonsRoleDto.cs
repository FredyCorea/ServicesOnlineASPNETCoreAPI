using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class PersonsRoleDto
     {
          public PersonsRoleDto() { }
          public int PersonRolesId { get; set; }
          //public int PersonId { get; set; }
          //public int RoleId { get; set; }
          //public virtual Person Person { get; set; }
          public virtual Role role { get; set; }
     }
}
