using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class RoleDto
     {
          public RoleDto() { }
          public int RoleId { get; set; }
          public string RoleName { get; set; }

          // public virtual ICollection<PersonsRole> PersonsRoles { get; set; }
     }
}
