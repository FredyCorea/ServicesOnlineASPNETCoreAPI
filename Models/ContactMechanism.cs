using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class ContactMechanism
    {
        public int ContMechId { get; set; }
        public int EntityId { get; set; }
        public int AddressId { get; set; }
        public DateTime? ValidUntil { get; set; }
        public int? ContactTypeId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SiteUrl { get; set; }
        public int? IsPrimary { get; set; }

        public virtual Address Address { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Entity Entity { get; set; }
    }
}
