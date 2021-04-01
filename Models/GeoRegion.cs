using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class GeoRegion
    {
        public GeoRegion()
        {
            //Services = new HashSet<Service>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }

        //public virtual ICollection<Service> Services { get; set; }
    }
}
