using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class PropertyType
    {
        public PropertyType()
        {
            Properties = new HashSet<Property>();
        }

        public int PropertyTypeId { get; set; }
        public string PropTypeName { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
