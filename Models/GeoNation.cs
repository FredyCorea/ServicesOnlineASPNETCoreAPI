using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class GeoNation
    {
        public GeoNation()
        {
            //GeoCities = new HashSet<GeoCity>();
        }

        public int NationId { get; set; }
        public string Isocode { get; set; }
        public string NationName { get; set; }

        //public virtual ICollection<GeoCity> GeoCities { get; set; }
    }
}
