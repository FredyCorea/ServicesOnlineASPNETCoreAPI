using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class PersonsRole
    {
        public int PersonRolesId { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }

          //public virtual Person Person { get; set; }
          public virtual Role Role { get; set; }

     }
}
