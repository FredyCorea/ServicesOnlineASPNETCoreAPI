using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class GeoCity
    {
        public GeoCity()
        {
            //Services = new HashSet<Service>();
        }

        public int CityId { get; set; }
        public string Iatacode { get; set; }
        public string CityName { get; set; }
        public int? NationId { get; set; }

        //public virtual GeoNation Nation { get; set; }
        //public virtual ICollection<Service> Services { get; set; }
    }
}
