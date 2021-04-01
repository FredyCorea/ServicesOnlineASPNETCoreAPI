using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class VEntity
    {
        public int EntityId { get; set; }
        public int? PersonId { get; set; }
        public string LastName { get; set; }
        public string PersonName { get; set; }
        public int? RoomId { get; set; }
        public int? RoleId { get; set; }
        public string RoleName { get; set; }
        public int? PropertyId { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocTypeName { get; set; }
    }
}
