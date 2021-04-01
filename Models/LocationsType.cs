using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class LocationsType
    {
        public LocationsType()
        {
            //Locations = new HashSet<Location>();
        }

        public int LocTypeId { get; set; }
        public string LocTypeName { get; set; }

        //public virtual ICollection<Location> Locations { get; set; }
    }
}
