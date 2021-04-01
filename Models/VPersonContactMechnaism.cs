using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class VPersonContactMechnaism
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string LastName { get; set; }
        public int RoomId { get; set; }
        public string RoleName { get; set; }
        public string ContactTypeName { get; set; }
        public int? AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public string County { get; set; }
        public int? NationId { get; set; }
        public string ZipCode { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SiteUrl { get; set; }
        public int? IsPrimary { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }
}
