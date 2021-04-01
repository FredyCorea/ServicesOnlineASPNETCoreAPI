using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class Property
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public int PropertyTypeId { get; set; }

        public virtual PropertyType PropertyType { get; set; }
    }
}
