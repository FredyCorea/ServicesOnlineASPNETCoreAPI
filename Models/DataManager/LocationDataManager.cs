using Microsoft.EntityFrameworkCore;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class LocationDataManager : IDataRepository<Location, LocationDto>
     {
          //references to dependencies for injection
          private readonly DataAccessContext DbContext;

          // constructor and injection
          public LocationDataManager(DataAccessContext dbContext)
          {
               DbContext = dbContext;
          }

          //interface implementation for data manipulation
          IEnumerable<Location> IDataRepository<Location, LocationDto>.GetAll()
          {
               //var l = DbContext.Locations.ToList();
               var l = DbContext.Locations
                    .Include(e => e.Entities)
                    .Include(e => e.LocationType);
               return l;
          }

          Location IDataRepository<Location, LocationDto>.Get(long id)
          {
               var l = DbContext.Locations.SingleOrDefault(l => l.LocationId == id);
               return l;
          }

          void IDataRepository<Location, LocationDto>.Add(Location entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Location, LocationDto>.Delete(Location entity)
          {
               throw new NotImplementedException();
          }

          LocationDto IDataRepository<Location, LocationDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Location, LocationDto>.Update(Location entityToUpdate, Location entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<Location> IDataRepository<Location, LocationDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<Location, LocationDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
