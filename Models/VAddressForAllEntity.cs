using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class VAddressForAllEntity
    {
        public int ContMechId { get; set; }
        public int EntityId { get; set; }
        public string ContactTypeName { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string County { get; set; }
        public string ZipCode { get; set; }
    }
}
