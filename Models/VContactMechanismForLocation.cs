using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class VContactMechanismForLocation
    {
        public string LocationName { get; set; }
        public string LocTypeName { get; set; }
        public int? ContMechId { get; set; }
        public string ContactTypeName { get; set; }
        public int? EntityId { get; set; }
        public int? AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SiteUrl { get; set; }
    }
}
