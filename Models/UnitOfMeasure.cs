using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class UnitOfMeasure
    {
        public UnitOfMeasure()
        {
            //ServiceDurUoms = new HashSet<Service>();
            //ServiceUnitOfMeasures = new HashSet<Service>();
        }

        public int UoMid { get; set; }
        public string UomName { get; set; }

        //public virtual ICollection<Service> ServiceDurUoms { get; set; }
        //public virtual ICollection<Service> ServiceUnitOfMeasures { get; set; }
    }
}
