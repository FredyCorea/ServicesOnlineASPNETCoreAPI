using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class State
    {
        public State()
        {
            Addresses = new HashSet<Address>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
