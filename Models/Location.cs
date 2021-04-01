using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class Location
    {
        public Location()
        {
            Entities = new HashSet<Entity>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int LocationTypeId { get; set; }

        public virtual LocationsType LocationType { get; set; }
        public virtual ICollection<Entity> Entities { get; set; }
    }
}
