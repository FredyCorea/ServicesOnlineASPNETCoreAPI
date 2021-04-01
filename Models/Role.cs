using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class Role
    {
        public Role()
        {
            //PersonsRoles = new HashSet<PersonsRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        //public virtual ICollection<PersonsRole> PersonsRoles { get; set; }
    }
}
