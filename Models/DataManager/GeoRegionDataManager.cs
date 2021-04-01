using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class GeoRegionDataManager : IDataRepository<GeoRegion, GeoRegionDto>
     {
          private readonly DataAccessContext _DataAccessContext;

          public GeoRegionDataManager(DataAccessContext DataAccessContext)
          {
               _DataAccessContext = DataAccessContext;
          }

          //Data manipulation
          IEnumerable<GeoRegion> IDataRepository<GeoRegion, GeoRegionDto>.GetAll()
          {
             return   _DataAccessContext.GeoRegions.ToList();
          }

          void IDataRepository<GeoRegion, GeoRegionDto>.Add(GeoRegion entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<GeoRegion, GeoRegionDto>.Delete(GeoRegion entity)
          {
               throw new NotImplementedException();
          }

          GeoRegion IDataRepository<GeoRegion, GeoRegionDto>.Get(long id)
          {
               throw new NotImplementedException();
          }


          GeoRegionDto IDataRepository<GeoRegion, GeoRegionDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<GeoRegion, GeoRegionDto>.Update(GeoRegion entityToUpdate, GeoRegion entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<GeoRegion> IDataRepository<GeoRegion, GeoRegionDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<GeoRegion, GeoRegionDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
