using System;
using System.Collections.Generic;

#nullable disable

namespace ServicesOnLineAPI
{
    public partial class Service
    {
        public Service()
        {
            //Orders = new HashSet<Order>();
            PriceLists = new HashSet<PriceList>();
            Promotions = new HashSet<Promotion>();
            ServiceMedia = new HashSet<ServiceMedia>();
            ServiceScheds = new HashSet<ServiceSched>();
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int ServicesId { get; set; }
        public string ServicesName { get; set; }
        public string ServiceDescr { get; set; }
        public string Requirements { get; set; }
        public int? RegionId { get; set; }
        public int? ServTypeId { get; set; }
        public int? CityId { get; set; }
        public int? Duration { get; set; }
        public int? DurUomId { get; set; }
        public int? UnitOfMeasureId { get; set; }
        public int? MaxCapacity { get; set; }

        public virtual GeoCity City { get; set; }
        public virtual UnitOfMeasure DurUom { get; set; }
        public virtual GeoRegion Region { get; set; }
        public virtual ServicesType ServType { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        //public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PriceList> PriceLists { get; set; }
        public virtual ICollection<Promotion> Promotions { get; set; }
        public virtual ICollection<ServiceMedia> ServiceMedia { get; set; }
        public virtual ICollection<ServiceSched> ServiceScheds { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
