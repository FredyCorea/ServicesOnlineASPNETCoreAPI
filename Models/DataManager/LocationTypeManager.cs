using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class LocationTypeManager : IDataRepository<LocationsType, LocationTypeDto>
     {
          //references to dependencies for injection
          private readonly DataAccessContext DbContext;

          //constructor
          public LocationTypeManager(DataAccessContext dbContext)
          {
               DbContext = dbContext;
          }

          //inteface implementation for data manipulation

          IEnumerable<LocationsType> IDataRepository<LocationsType, LocationTypeDto>.GetAll()
          {
               return DbContext.LocationsTypes;
          }

          void IDataRepository<LocationsType, LocationTypeDto>.Add(LocationsType entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<LocationsType, LocationTypeDto>.Delete(LocationsType entity)
          {
               throw new NotImplementedException();
          }

          LocationsType IDataRepository<LocationsType, LocationTypeDto>.Get(long id)
          {
               throw new NotImplementedException();
          }



          LocationTypeDto IDataRepository<LocationsType, LocationTypeDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<LocationsType, LocationTypeDto>.Update(LocationsType entityToUpdate, LocationsType entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<LocationsType> IDataRepository<LocationsType, LocationTypeDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<LocationsType, LocationTypeDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
