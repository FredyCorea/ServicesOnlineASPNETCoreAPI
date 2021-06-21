using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class GeoCityDataManager : IDataRepository<GeoCity, GeoCityDto>
     {
          //Inject the db context
          private readonly DataAccessContext DbContext;

          //Default contructor
          public GeoCityDataManager(DataAccessContext dbContext)
          {
               DbContext = dbContext;
          }

          IEnumerable<GeoCity> IDataRepository<GeoCity, GeoCityDto>.GetAll()
          {
               //use the injected DbContext to fetch data
               var cities = DbContext.GeoCities.ToList();
               return cities;
          }

          void IDataRepository<GeoCity, GeoCityDto>.Add(GeoCity entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<GeoCity, GeoCityDto>.Delete(GeoCity entity)
          {
               throw new NotImplementedException();
          }

          GeoCity IDataRepository<GeoCity, GeoCityDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          GeoCityDto IDataRepository<GeoCity, GeoCityDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<GeoCity, GeoCityDto>.Update(GeoCity entityToUpdate, GeoCity entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<GeoCity> IDataRepository<GeoCity, GeoCityDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<GeoCity, GeoCityDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
