using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class ServicesType
    {
        public ServicesType()
        {
            //Services = new HashSet<Service>();
        }

        public int ServTypeId { get; set; }
        public string ServTypeName { get; set; }

        //public virtual ICollection<Service> Services { get; set; }
    }
}
