using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class VService
    {
        public int ServicesId { get; set; }
        public string ServicesName { get; set; }
        public string ServiceDescr { get; set; }
        public string Requirements { get; set; }
        public int? RegionId { get; set; }
        public string RegionName { get; set; }
        public int? ServTypeId { get; set; }
        public string ServTypeName { get; set; }
        public int? CityId { get; set; }
        public int? MaxCapacity { get; set; }
        public string CityName { get; set; }
        public int? Duration { get; set; }
        public int? DurUomId { get; set; }
        public string UomName { get; set; }
        public string Expr1 { get; set; }
    }
}
